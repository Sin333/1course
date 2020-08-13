using System;

namespace Tree
{
    class TreeNote
    {
        public int value;
        public TreeNote left;
        public TreeNote right;
        public TreeNote(int k)
        {
            value = k;
        }
        public TreeNote()
        {

        }
    }
    class Tree
    {
        public TreeNote root;
        public Tree()
        {

        }

        //Empty for Tree
        public bool Empty_for_Tree()
        {
            return root == null;
        }

        //1 PrintbyLayers Вывод класса Tree через Queue
        public void PrintByLayers()
        {
            Queue q = new Queue();
            q.Enqueue(root);
            while (!q.Empty())
            {
                TreeNote tmp = q.Dequeue();
                Console.Write(tmp.value + " ");
                if (tmp.left != null)
                {
                    q.Enqueue(tmp.left);
                }
                if (tmp.right != null)
                {
                    q.Enqueue(tmp.right);
                }
            }
            Console.WriteLine();
        }

        //2 Print (РЕКУРСИЕЙ - переделал как просил =) )
        ////int Sum = 0;
        public void Print_to_Sum()
        {
            TreeNote tmp = root;
            if (Empty_for_Tree())
            {
                ErrorMessageEmpty();
                return;
            }
            else
            {
                Print_Left_or_Right(tmp);
            }
            ////Console.WriteLine("Сумма концевых чисел двоичного дерева"+Sum);
        }
        public void Print_Left_or_Right(TreeNote tmp)
        {
            if (tmp.left != null)
            {
                Print_Left_or_Right(tmp.left);
            }
            ////if(tmp.left==null && tmp.right==null)
            ////{
            ////    Sum += tmp.value;
            ////}
            Console.Write(tmp.value + " "); //center TreeNote
             if (tmp.right != null)
            {
                Print_Left_or_Right(tmp.right);
            }
        }

        //3 Insert (ЗАКОНЧИТЬ!) (Добавляет эл-т в дерево поиска)
        public bool Insert(int k)
        {
            TreeNote tmp = root;
            if (root.value == k)
            {
                return false;
            }
            while (tmp.left != null || tmp.right != null)
            {
                //Left
                if (tmp.left != null)
                {
                    //
                    if (tmp.left.value != k)
                    {
                        if (tmp.value > k)
                        {
                            tmp = tmp.left;
                            continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (tmp.value > k && tmp.left == null)
                {
                    TreeNote NewTN = new TreeNote();
                    NewTN.value = k;
                    tmp.left = NewTN;
                    break;
                }
                //Right
                if (tmp.right != null)
                {
                    if (tmp.right.value != k)
                    {
                        if (tmp.value < k)
                        {
                            tmp = tmp.right;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (tmp.value < k && tmp.right == null)
                {
                    TreeNote NewTN = new TreeNote();
                    NewTN.value = k;
                    tmp.right = NewTN;
                    break;
                }
                //end while
            }
            return true;
        }

        //4 Contains
        public bool Contains(int k)
        {
            TreeNote tmp = root;
            if (root.value == k)
            {
                return true;
            }
            while (tmp.left != null || tmp.right != null)
            {
                if (tmp.value > k)
                {
                    tmp = tmp.left;
                }
                else
                {
                    tmp = tmp.right;
                }
                if (tmp.value == k)
                {
                    return true;
                }
            }
            return false;
        }

        //5 Remove
        public bool Remove(int k)
        {
            if (Empty_for_Tree())
            {
                ErrorMessageEmpty();
                return false;
            }
            TreeNote tmp = root;
            if (root.value == k)
            {
                return true;
            }
            while (tmp.left != null || tmp.right != null)
            {
                //Left
                if (tmp.left != null)
                {
                    if (tmp.value > k)
                    {
                        if (tmp.left.value == k)
                        {
                            tmp.left = null;
                            return true;
                        }
                        tmp = tmp.left;
                        continue;
                    }
                }
                //Right
                if (tmp.right != null)
                {
                    if (tmp.value < k)
                    {
                        if (tmp.right.value == k)
                        {
                            tmp.right = null;
                            return true;
                        }
                        tmp = tmp.right;
                    }
                }
                //end while
            }
            return false;
        }

        //6 Equals
        bool Equalsbool = true; //Временная переменная для Equals
        public bool Equals(Tree tree2)
        {
            TreeNote tmp = root;
            TreeNote tmp2 = tree2.root;
            if (tmp.value == tmp2.value)
            {
                Equals_Left_or_Right(tmp, tmp2);
            }
            return Equalsbool;
        }
        public void Equals_Left_or_Right(TreeNote tmp, TreeNote tmp2)
        {
            //Left
            if ((tmp.left == null && tmp2.left == null) || (tmp.left != null && tmp2.left != null))
            {
                if (tmp.left != null)
                {
                    if (Equalsbool == true)
                    {
                        if (tmp.left.value == tmp2.left.value)
                        {
                            Equals_Left_or_Right(tmp.left, tmp2.left);
                        }
                        else
                        {
                            Equalsbool = false;
                        }
                    }
                }
            }
            else
            {
                Equalsbool = false;
            }
            //Right
            if ((tmp.right == null && tmp2.right == null) || (tmp.right != null && tmp2.right != null))
            {
                if (tmp.right != null)
                {
                    if (Equalsbool == true)
                    {
                        if (tmp.right.value == tmp2.right.value)
                        {
                            Equals_Left_or_Right(tmp.right, tmp2.right);
                        }
                        else
                        {
                            Equalsbool = false;
                        }
                    }
                }
            }
            else
            {
                Equalsbool = false;
            }
        }

        //7 HasSameValues
        public bool HasSameValues(Tree tree2)
        {
            if(root==null && tree2.root==null)
            {
                return true; // У них одинаково нет эл-тов
            }
            if(root==null && tree2.root!=null)
            {
                return false; // У одного из них есть хоть 1 эл-т
            }
            if(root!=null && tree2.root==null)
            {
                return false; // У одного из них есть хоть 1 эл-т
            }
            Queue q1 = new Queue();
            Queue q2 = new Queue();
            q1.Enqueue(root);
            //Tree1
            while (!q1.Empty() && !q2.Empty())
            {
                TreeNote tmp2 = q2.Dequeue();
                if (!q2.Empty())
                {
                    Console.Write(tmp2.value + " ");
                    if (tmp2.left != null)
                    {
                        q2.Enqueue(tmp2.left);
                    }
                    if (tmp2.right != null)
                    {
                        q2.Enqueue(tmp2.right);
                    }
                }
                TreeNote tmp = q1.Dequeue();
                Console.Write(tmp.value + " ");
                if (tmp.left != null)
                {
                    q1.Enqueue(tmp.left);
                }
                if (tmp.right != null)
                {
                    q1.Enqueue(tmp.right);
                }

                if (q1 == q2)
                {

                }

            }
            //Tree2
            while (!q2.Empty())
            {
                TreeNote tmp = q2.Dequeue();
                Console.Write(tmp.value + " ");
                if (tmp.left != null)
                {
                    q2.Enqueue(tmp.left);
                }
                if (tmp.right != null)
                {
                    q2.Enqueue(tmp.right);
                }
            }
            //End
            return true;
        }
        //public void HSV_Left_or_Right(TreeNote tmp,bool b)
        //{
        //    if (tmp.left != null)
        //    {
        //        HSV_Left_or_Right(tmp.left,b);
        //    }
        //    if (b==true)
        //    {
        //    }
        //    else
        //    {
        //    }

        //    if (tmp.right != null)
        //    {
        //        HSV_Left_or_Right(tmp.left,b);
        //    }
        //}

        //8 IsSymmetric
        int Leftvalue = 0;
        int Rightvalue = 0;
        public bool IsSimmetric()
        {
            TreeNote tmp = root;
            if (Empty_for_Tree())
            {
                ErrorMessageEmpty();
                return false;
            }
            else
            {
                IsSimmetric_Left_or_Right(tmp.left);
                IsSimmetric_Left_or_Right(tmp.right);
            }
            if (Leftvalue == Rightvalue)
                return true;
            else
                return false;
        }
        public void IsSimmetric_Left_or_Right(TreeNote tmp)
        {
            if ((tmp.left == null && tmp.right == null) || (tmp.left != null && tmp.right != null))
            {
                if (tmp.left != null)
                {
                    Leftvalue++;
                    IsSimmetric_Left_or_Right(tmp.left);
                }
                //
                if (tmp.right != null)
                {
                    Rightvalue++;
                    IsSimmetric_Left_or_Right(tmp.right);
                }
            }
        }

        //Message Error
        public void ErrorMessageEmpty()
        {
            Console.WriteLine("Error! This Tree is empty");
        }
    }
    //QueueNote
    class QueueNote
    {
        public TreeNote value;
        public QueueNote next;
        public QueueNote(TreeNote tmp)
        {
            value = tmp;
        }
        public QueueNote()
        {

        }
    }
    //Queue(Basic)
    class Queue
    {
        QueueNote begin;
        public Queue()
        {

        }
        //Проверка не пустой ли первый эл-т
        public bool Empty()
        {
            return begin == null;
        }
        //Добавляет эл-т(Значение) в конец списка!
        public void Enqueue(TreeNote tmp)
        {
            QueueNote q1 = new QueueNote(tmp);
            if (begin == null)
            {
                begin = q1;
                return;
            }
            QueueNote current = begin;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = q1;
        }
        //Добавляет эл-т в конец списка!
        public TreeNote Dequeue()
        {
            QueueNote q1 = begin;
            if (Empty())
            {
                Console.WriteLine("Очередь пустая");
                return null;
            }
            begin = q1.next;
            return q1.value;
        }
        //Print Queue
        public void Print()
        {
            QueueNote current = begin;
            while (current != null)
            {
                Console.Write(current.value.value + "  ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TREE first
            Tree tre1 = new Tree();
            //TREE second
            Tree tre2 = new Tree();
            //Tree third
            Tree tre3 = new Tree();

            //Left first
            tre1.root = new TreeNote(7);
            tre1.root.left = new TreeNote(5);
            tre1.root.left.left = new TreeNote(1);
            tre1.root.left.right = new TreeNote(6);
            tre1.root.left.left.right = new TreeNote(3);
            tre1.root.left.left.right.left = new TreeNote(2);
            //Right first
            tre1.root.right = new TreeNote(12);
            tre1.root.right.left = new TreeNote(10);
            tre1.root.right.right = new TreeNote(15);
            tre1.root.right.left.left = new TreeNote(9);
            tre1.root.right.left.right = new TreeNote(11);

            //Left second
            tre2.root = new TreeNote(7);
            tre2.root.left = new TreeNote(5);
            tre2.root.left.left = new TreeNote(1);
            tre2.root.left.right = new TreeNote(6);
            tre2.root.left.left.right = new TreeNote(3);
            tre2.root.left.left.right.left = new TreeNote(2);
            //Right second
            tre2.root.right = new TreeNote(12);
            tre2.root.right.left = new TreeNote(10);
            tre2.root.right.right = new TreeNote(15);
            tre2.root.right.left.left = new TreeNote(9);
            tre2.root.right.left.right = new TreeNote(11);

            //Left third
            tre3.root = new TreeNote(5);
            tre3.root.left = new TreeNote(3);
            tre3.root.right = new TreeNote(9);
            tre3.root.left.left = new TreeNote(2);
            tre3.root.right.right = new TreeNote(19);

            ///Задания!////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Спасибо за ожидание! (за, то что ждали и проверили мои программы");
            ///1.PrintByLabers////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("1.PrintByLayers");   //Yes
            tre1.PrintByLayers();
            ///2.Print////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("2.Print");           //Yes
            //tre1.Print();
            ///3.Insert////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("3.Insert");          //Yes! Добавляет новый эл-т в конец дерева, как в задании
            tre1.Insert(4);
            //tre1.Print();
            ///4.Contains////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("4.Contains");        //Yes Проверяет есть ли, этот эл-т в дереве
            if (tre1.Contains(6))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            ///4.Remove////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("5.Remove");          //Yes Удаляет эл-т из дерева
            tre1.Remove(4);
            //tre1.Print();

            //Примечание для Equals: Деревья после Insert изменятся
            Console.WriteLine("6.Equals");          //Yes! Проверяет ветки и числа, как в задании
            //tre1.Print(); //Написал чтобы видеть самому tre1
            //tre2.Print(); //Написал чтобы видеть самому tre2
            if (tre1.Equals(tre2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine("7.HasSameVAlues");
            if (tre1.HasSameValues(tre2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine("8.IsSymmetric");
            if(tre3.IsSimmetric())
                Console.WriteLine("Tree is symmetric");
            else
                Console.WriteLine("Tree is not symmetric");
            ///END!////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Простите что вам пришлось ждать мои программы. =(");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Работу выполнил: Ермошин Илья 09-533             ");
            Console.WriteLine("-------------------------------------------------");
            Console.ReadKey();
        }
    }
}