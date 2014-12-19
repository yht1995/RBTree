﻿using System;
using System.Collections.Generic;

namespace RBTree
{
    public class Node
    {
        private TypeRate rate; //数据
        private Node left; //左孩子
        private Node right; //右孩子
        private bool color; //色
        private List<Student> studentList;

        //构造方法
        public Node(Student s)
        {
            rate = s.Rate;
            studentList = new List<Student>();
            studentList.Add(s);
        }

        public void AddStudent(Student s)
        {
            studentList.Add(s);
        }

        //属性
        public TypeRate Key //数据
        {
            get { return rate; }
            set { rate = value; }
        }
        public Node Left //左孩子
        {
            get { return left; }
            set { left = value; }
        }
        public Node Right //右孩子
        {
            get { return right; }
            set { right = value; }
        }
        public bool IsRed
        {
            get { return color; }
            set { color = value; }
        }
        public List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        public string RateString()
        {
            switch (this.rate)
            {
                case (TypeRate.AAplus):
                    return ("AA+");
                case (TypeRate.Bplus):
                    return ("B+");
                case (TypeRate.Bminus):
                    return ("B-");
                case (TypeRate.Cplus):
                    return ("C+");
                default:
                    return (this.rate.ToString());
            }
        }

        public int RateMax()
        {
            if ((int)rate <9)
            {
                return (99 - (9 - ((int)rate)) * 5);
            }
            else
            {
                return (100);
            }
        }

        public int RateMin()
        {
            if ((int)rate > 0)
            {
                return (95 - (9 - ((int)rate)) * 5);
            }
            else
            {
                return (0);
            }
        }
    }

    public class RBTree
    {    //成员变量
        private Node _head; //头指针

        public Node Head
        {
            get { return _head; }
            set { _head = value; }
        }

        private Node[] path = new Node[32]; //记录访问路径上的结点
        private int p; //表示当前访问到的结点在_path上的索引

        public bool Add(Student s) //添加一个元素
        {  //如果是空树，则新结点成为二叉排序树的根
            if (_head == null)
            {
                _head = new Node(s);
                _head.IsRed = false;
                return true;
            }
            p = 0;
            //parent为上一次访问的结点，current为当前访问结点
            Node parent = null, current = _head;
            while (current != null)
            {
                path[p++] = current; //将路径上的结点插入数组
                //如果插入值已存在，则插入失败
                if (current.Key == s.Rate)
                {
                    Student find = current.StudentList.Find(delegate(Student a)
                    {
                        return (a.ID == s.ID && a.Name == s.Name);
                    }); 
                    if (find == null)
                    {
                        current.AddStudent(s);
                        return true;
                    }
                    else
                    {
                        Exception ex = new Exception("该学生已存在！");
                        throw(ex);
                    }
                }
                parent = current;
                //当插入值小于当前结点，则继续访问左子树，否则访问右子树
                current = (s.Rate < parent.Key) ? parent.Left : parent.Right;
            }
            current = new Node(s); //创建新结点
            current.IsRed = true;
            if (s.Rate < parent.Key) //如果插入值小于双亲结点的值
            {
                parent.Left = current; //成为左孩子
            }
            else //如果插入值大于双亲结点的值
            {
                parent.Right = current; //成为右孩子
            }
            if (!parent.IsRed)
            {
                return true;
            }
            path[p] = current;
            //回溯并旋转
            while ((p -= 2) >= 0) //现在p指向插入点的祖父结点
            {
                Node grandParent = path[p];
                parent = path[p + 1];
                if (!parent.IsRed)
                {
                    break;
                }
                Node uncle = grandParent.Left == parent ? grandParent.Right : grandParent.Left;
                current = path[p + 2];
                if (IsRed(uncle)) //叔父存在并且为红色的情况
                {
                    parent.IsRed = false;
                    uncle.IsRed = false;
                    if (p > 0) //如果祖父不是根结点，则将其染成红色
                    {
                        grandParent.IsRed = true;
                    }
                }
                else //叔父不存在或为黑的情况需要旋转
                {
                    Node newRoot;
                    if (grandParent.Left == parent) //如果当前结点及父结点同为左孩子或右孩子
                    {
                        newRoot = (parent.Left == current) ? LL(grandParent) : LR(grandParent);
                    }
                    else
                    {
                        newRoot = (parent.Right == current) ? RR(grandParent) : RL(grandParent);
                    }
                    grandParent.IsRed = true; //祖父染成红色
                    newRoot.IsRed = false; //新根染成黑色
                    //将新根同曾祖父连接
                    ReplaceChildOfNodeOrRoot((p > 0) ? path[p - 1] : null, grandParent, newRoot);
                    return true; //旋转后不需要继续回溯，添加成功，直接退出
                }
            }
            return true;
        }
        //旋转根旋转后换新根
        private void ReplaceChildOfNodeOrRoot(Node parent, Node child, Node newChild)
        {
            if (parent != null)
            {
                if (parent.Left == child)
                {
                    parent.Left = newChild;
                }
                else
                {
                    parent.Right = newChild;
                }
            }
            else
            {
                _head = newChild;
            }
        }
        private static bool IsBlack(Node node)
        {
            return ((node != null) && !node.IsRed);
        }

        private static bool IsNullOrBlack(Node node)
        {
            if (node != null)
            {
                return !node.IsRed;
            }
            return true;
        }

        private static bool IsRed(Node node)
        {
            return ((node != null) && node.IsRed);
        }
        //删除指定值
        public bool Remove(Student s)
        {
            p = -1;
            //parent表示双亲结点，node表示当前结点
            Node node = _head;
            //寻找指定值所在的结点
            while (node != null)
            {
                path[++p] = node;
                if (s.Rate == node.Key)
                {
                    Student find = node.StudentList.Find(delegate(Student a)
                    {
                        return (a.ID == s.ID && a.Name == s.Name);
                    }); 
                    if (find == null)
                    {
                        throw(new Exception("没有该学生"));
                    }
                    if (find != null)
                    {
                        node.StudentList.Remove(find);
                    }
                    if (node.StudentList.Count == 0)
                    {
                        RemoveNode(node);//现在p指向被删除结点
                    }
                    return true; //返回true表示删除成功
                }
                if (s.Rate < node.Key)
                {   //如果删除值小于当前结点，则向左子树继续寻找
                    node = node.Left;
                }
                else
                {   //如果删除值大于当前结点，则向右子树继续寻找
                    node = node.Right;
                }
            }
            throw (new Exception("没有该分数段"));
        }
        //删除指定结点
        private void RemoveNode(Node node)
        {
            Node tmp = null; //tmp最终指向实际被删除的结点
            //当被删除结点存在左右子树时
            if (node.Left != null && node.Right != null)
            {
                tmp = node.Left; //获取左子树
                path[++p] = tmp;
                while (tmp.Right != null) //获取node的中序遍历前驱结点，并存放于tmp中
                {   //找到左子树中的最右下结点
                    tmp = tmp.Right;
                    path[++p] = tmp;
                }
                //用中序遍历前驱结点的值代替被删除结点的值
                node.Key = tmp.Key;
            }
            else
            {
                tmp = node;
            }
            //当只有左子树或右子树或为叶子结点时
            //首先找到惟一的孩子结点
            Node newTmp = tmp.Left;
            if (newTmp == null) //如果只有右孩子或没孩子
            {
                newTmp = tmp.Right;
            }
            if (p > 0)
            {
                Node parent = path[p - 1];
                if (parent.Left == tmp)
                {   //如果被删结点是左孩子
                    parent.Left = newTmp;
                }
                else
                {   //如果被删结点是右孩子
                    parent.Right = newTmp;
                }
                if (!tmp.IsRed && IsRed(newTmp))
                {
                    newTmp.IsRed = false;
                    return;
                }
            }
            else  //当删除的是根结点时
            {
                _head = newTmp;
                if (_head != null)
                {
                    _head.IsRed = false;
                }
                return;
            }
            path[p] = newTmp;

            //如果被删除的是红色结点，则它必定是叶子结点，删除成功，返回
            if (IsRed(tmp))
            {
                return;
            }
            //删除完后进行旋转，现在p指向实际被删除的位置,这个位置可能为空,tmp指向被删除的旧点，
            while (p > 0)
            {   //剩下的是双黑的情况
                //首先找到兄弟结点
                Node current = path[p];
                Node parent = path[p - 1];
                bool currentIsLeft = (parent.Left == current);
                Node sibling = currentIsLeft ? parent.Right : parent.Left;
                //红兄的情况，需要LL旋转或RR旋转
                if (IsRed(sibling))
                {
                    Node newRoot;
                    if (currentIsLeft)
                    {
                        newRoot = RR(parent);
                    }
                    else
                    {
                        newRoot = LL(parent);
                    }
                    ReplaceChildOfNodeOrRoot(p > 1 ? path[p - 2] : null, parent, newRoot);
                    sibling.IsRed = false;
                    parent.IsRed = true;
                    //回溯点降低
                    path[p - 1] = newRoot;
                    path[p] = parent;
                    path[++p] = current;
                }
                else //黑兄的情况
                {
                    //黑兄二黑侄
                    if (IsNullOrBlack(sibling.Left) && IsNullOrBlack(sibling.Right))
                    {  //红父的情况
                        if (parent.IsRed)
                        {
                            parent.IsRed = false;
                            sibling.IsRed = true;
                            if (current != null)
                            {
                                current.IsRed = false;
                            }
                            break; //删除成功
                        }
                        else //黑父的情况
                        {
                            parent.IsRed = IsRed(current);
                            if (current != null)
                            {
                                current.IsRed = false;
                            }
                            sibling.IsRed = true;
                            p--; //需要继续回溯
                        }
                    }
                    else //黑兄红侄
                    {
                        Node newRoot;
                        if (currentIsLeft) //兄弟在右边
                        {
                            if (IsRed(sibling.Right)) //红侄在右边
                            {  //RR型旋转
                                newRoot = RR(parent);
                                sibling.Right.IsRed = false;
                            }
                            else
                            {  //RL型旋转
                                newRoot = RL(parent);
                            }
                        }
                        else //兄弟在左边
                        {
                            if (IsRed(sibling.Left))
                            {  //LL型旋转
                                newRoot = LL(parent);
                                sibling.Left.IsRed = false;
                            }
                            else
                            {  //LR型旋转
                                newRoot = LR(parent);
                            }
                        }
                        if (current != null)
                        {
                            current.IsRed = false;
                        }
                        newRoot.IsRed = parent.IsRed;
                        parent.IsRed = false;
                        ReplaceChildOfNodeOrRoot(p > 1 ? path[p - 2] : null, parent, newRoot);
                        break; //不需要回溯，删除成功
                    }
                }
            }
        }
        //root为旋转根，rootPrev为旋转根双亲结点
        private Node LL(Node root) //LL型旋转，返回旋转后的新子树根
        {
            Node left = root.Left;
            root.Left = left.Right;
            left.Right = root;
            return left;
        }
        private Node LR(Node root) //LR型旋转，返回旋转后的新子树根
        {
            Node left = root.Left;
            Node right = left.Right;
            root.Left = right.Right;
            right.Right = root;
            left.Right = right.Left;
            right.Left = left;
            return right;
        }
        private Node RR(Node root) //RR型旋转，返回旋转后的新子树根
        {
            Node right = root.Right;
            root.Right = right.Left;
            right.Left = root;
            return right;
        }
        private Node RL(Node root) //RL型旋转，返回旋转后的新子树根
        {
            Node right = root.Right;
            Node left = right.Left;
            root.Right = left.Left;
            left.Left = root;
            right.Left = left.Right;
            left.Right = right;
            return left;
        }

        public List<Student> FindInRate(TypeRate rate)
        {
            if (_head == null)
            {
                return null;
            }
            Node parent = null, current = _head;
            while (current != null)
            {
                if (current.Key == rate)
                {
                    return (current.StudentList);
                }
                parent = current;
                current = (rate < parent.Key) ? parent.Left : parent.Right;
            }
            return null;
        }

        public List<Student> FindInScore(int min,int max)
        {
            List<Student> list = new List<Student>();
            if (_head == null)
            {
                return null;
            }
            Node parent = null, current = _head;
            while (current != null)
            {
                if (current.RateMax() >= max || current.RateMin() <= min)
                {
                    foreach(Student s in current.StudentList)
                    {
                        if (s.Socre<= max && s.Socre >= min)
                        {
                            list.Add(s);
                        }
                    }
                }
                parent = current;
                if (min < parent.RateMin())
                {
                    current = parent.Left;
                }
                else if (max > parent.RateMax())
                {
                    current = parent.Right;
                }
                else
                {
                    current = null;
                }
            }
            return list;
        }
        public List<Student> LevelTraversal()
        {
            Queue<Node> qNode = new Queue<Node>();
            List<Student> list = new List<Student>();
            qNode.Enqueue(_head);
            while (qNode.Count != 0)
            {
                Node top = qNode.Dequeue();
                if (top.Left != null)
                {
                    qNode.Enqueue(top.Left);
                }
                if (top.Right != null)
                {
                    qNode.Enqueue(top.Right);
                }
                foreach (Student stu in top.StudentList)
                {
                    list.Add(stu);
                }
            }
            return list;
        }

        public void InorderTraversal(Node node,List<Student> s)
        {
            if (node == null)
            {
                return;
            }
            InorderTraversal(node.Left,s);
            foreach (Student stu in node.StudentList)
            {
                s.Add(stu);
            }
            InorderTraversal(node.Right,s);
        }
    }
}