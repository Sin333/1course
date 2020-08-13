using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// List<int> a = new List<int>();
namespace _18._03._16_List_Листы_
{
    class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode back;
        public ListNode(int _value)
        {
            value = _value;
        }
        public ListNode()
        {

        }
    }
    class List
    {
        public ListNode begin;


        public List()
        {

        }

        public List(int k)
        {
            begin = new ListNode();
            begin.value = k;
        }

        //public List(int[] ram)
        //{
        //    for (int i = 0; i < ram.Length; i++)
        //    {
        //        begin.value = ram[i];
        //        begin = begin.next;
        //    }
        //}
        public List(int[] array)
        {
            // for empty array too
            ListNode current = null;
            ListNode previous = null;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                current = new ListNode();
                current.value = array[i];
                current.next =previous;
                previous = current;
            }
            begin = current;
        }

        //Откладка-ВЫВОД
        public const bool DEBUG = false;
        //Print
        public void Print()
        {
            ListNode current = begin;
            while (current != null)
            {
                Console.Write(current.value + "  ");
                current = current.next;
            }
            Console.WriteLine();
        }
        //Число в начало поставить
        public void InsertBegin(int k)
        {
            //ListNote tmp = new ListNote();
            //tmp.value = k;
            //tmp.next = begin;
            //begin = tmp;
            ListNode tmp = begin;
            begin = new ListNode();
            begin.value = k;
            begin.next = tmp;
        }
        //Число в конец поставить
        public void InsertEnd(int k)
        {
            ListNode tmp = begin;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            ListNode two = new ListNode();
            two.value = k;
            tmp.next = two;
        }
        //Написать номер индекса введённого числа
        public int IndexOf(int k)
        {
            ListNode tmp = begin;
            int i = 0;
            try
            {
                while (k != tmp.value)
                {
                    if (tmp != null)
                    {
                        i++;
                        tmp = tmp.next;
                    }
                }
                //Console.WriteLine("Элемент {0} находится под индексом {1}", k, i);
                return i;
            }
            catch
            {
                return -1;
                //Console.WriteLine("Ошибка ,этот элемент отсутствует");
            }
            //return 0;
        }
        //Вставить число после опр. индекса
        public bool Insert(int index, int value)
        {
            ListNode tmp = begin;
            int i = 0;
            while (index != i)
            {
                i++;
                tmp = tmp.next;
            }
            Console.WriteLine(i);
            ListNode two = new ListNode(value);
            two.next = tmp.next;
            tmp.next = two;
            return true;
        }
        //Удалить последний элемент
        public bool RemoveEnd()
        {
            ListNode tmp = new ListNode();
            tmp = begin;
            while (tmp.next != null)
            {
                tmp = tmp.next;
                if (tmp.next.next == null)
                    break;
            }
            tmp.next = null;
            return true;
        }
        //Удалить первый элемент
        public bool RemoveBegin()
        {
            ListNode tmp = new ListNode();
            if (tmp == null)
                return false;
            tmp = begin;
            tmp = tmp.next;
            begin = tmp;
            tmp = null;
            return true;
        }
        //Удалить введённое число
        public bool Remove(int k)
        {
            ListNode tmp = new ListNode();
            tmp = begin;
            while(tmp!=null)
            {
                if (tmp.next.value == k)
                    break;
                tmp = tmp.next;
            }
            ListNode end;
            if(tmp.next.next==null)
            {
                return RemoveEnd();
            }
            end = tmp.next.next;
            tmp.next = end;
            return true;
        }
        // Закончить
        public bool RemoveAtIndex(int index)
        {
            ListNode tmp = begin;
            int i = 0;
            while (tmp != null)
            {
                if (i != index)
                {
                    i++;
                    tmp = tmp.next;
                }
                else
                {
                    tmp = null;
                    break;
                }
            }
            ListNode end;
            if (tmp.next == null)
                return RemoveEnd();
            end = tmp.next.next;
            tmp.next = end;
            return true;
        }
        //Закончить
        public void Reverse()
        {
            ListNode start = begin, end;
            while(start !=null)
            {
                start = start.next;
            }
            end = start;
            while(end != start)
            {
                end.next = start.back;
            }
        }
        public bool Contains(int k)
        {
            ListNode tmp = begin;
            bool p = false;
            while (tmp.next != null)
            {
                if (k == tmp.value)
                {
                    //Console.WriteLine("true");
                    p = true;
                    break;
                }
                tmp = tmp.next;
            }
            //if (p == false)
            //Console.WriteLine("false");
            return p;
        }
        public int Count(int k)
        {
            ListNode tmp = begin;
            int i = 0;
            while (tmp.next != null)
            {
                if (tmp.value == k)
                    i++;
                tmp = tmp.next;
            }
            //Console.WriteLine(i);
            return i;
        }
        public int GetLength()
        {
            ListNode tmp = begin;
            int i = 1;
            while (tmp.next != null)
            {
                i++;
                tmp = tmp.next;
            }
            //Console.WriteLine("В списке {0} элемента", i);
            return i;
        }
        public int Max()
        {
            ListNode tmp = begin;
            int max = 0;
            while(tmp!=null)
            {
                if (max < tmp.value)
                    max = tmp.value;
                tmp = tmp.next;
            }
            if (DEBUG)
                Console.WriteLine("Максимальное числов списке: "+max);
            return max;
        }
        public int Sum()
        {
            ListNode tmp = begin;
            int sum=0;
            while(tmp!=null)
            {
                sum += tmp.value;
                tmp = tmp.next;
            }
            //Console.WriteLine("Сумма всех элементов листа = "+sum);
            return sum;
        }
        public int Average()
        {
            ListNode tmp = begin;
            int average, numbers = 0,sum=0;
            while(tmp!=null)
            {
                numbers++;
                sum += tmp.value;
                tmp = tmp.next;
            }
            average = sum / numbers;
            //Console.WriteLine("Среднее значение в списке = "+average);
            return average;
        }
        public int []ToArray()
        {
            ListNode tmp = begin;
            int numbers = 0,i=0;
            while(tmp!=null)
            {
                numbers++;
                tmp = tmp.next;
            }
            tmp = begin;
            int[] a = new int[numbers];
            //Console.Write("Массив: ");
            for (i = 0; i < numbers; i++)
            {
                a[i]=tmp.value;
                tmp = tmp.next;
      
                //Console.Write(a[i]+"  ");
            }
            return a;
            //Console.WriteLine();
        }
        public bool Equals(List list2)
        {
            bool p = false;
            ListNode first = begin;
            ListNode second = list2.begin;
            while(first!=null)
            {
                if (first == second)
                    p = true;
                else
                {
                    p = false;
                    break;
                }
                first = first.next;
                second = second.next;
            }
            if (p == true)
                //Console.WriteLine("Списки равны");
                return true;
            else
                //Console.WriteLine("Списки не равны");
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List myList = new List(1);
            Console.WriteLine("--InsertBegin--");
            myList.InsertBegin(2);
            myList.InsertBegin(4);
            myList.InsertBegin(3);
            myList.Print();

            Console.WriteLine("--InsertEnd--");
            myList.InsertEnd(9);
            myList.InsertEnd(14);
            myList.Print();

            Console.WriteLine("--IndexOf--");
            myList.IndexOf(44);
            myList.Insert(2, 8);
            myList.Print();

            Console.WriteLine("--RemoveEnd--");
            myList.RemoveEnd();
            myList.Print();

            Console.WriteLine("--RemoveBegin--");
            myList.RemoveBegin();
            myList.Print();

            Console.WriteLine("--Remove--");
            myList.Remove(1);
            myList.Print();

            Console.WriteLine("--RemoveAtIndex--");
            //myList.RemoveAtIndex(3);
            myList.Print();

            Console.WriteLine("--Reverse--");
            myList.Reverse();
            myList.Print();

            Console.WriteLine("--Contains---");
            myList.Contains(2);

            Console.WriteLine("--Count--");
            myList.Count(4);

            Console.WriteLine("--GetLength--");
            myList.GetLength();

            myList.Print();

            Console.WriteLine("--Max--");
            myList.Max();

            Console.WriteLine("--Sum--");
            myList.Sum();

            Console.WriteLine("--Average--");
            myList.Average();

            Console.WriteLine("--ToArray--");
            myList.Print();
            myList.ToArray();

            Console.WriteLine("--Equals--");
            List mylist2 = new List(4);
            myList.Equals(mylist2);

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("У меня была целая ночь чтобы всё сделать =)");
            //Console.WriteLine("А теперь отпустите это тело пожалуйста поспать, оно очень устало Z-z-z");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Ермошин Илья 09-533");
            Console.ReadKey();
        }
    }
    //class Program
    //{
    //    delegate void TestCase();
    //    private static int testRuns = 0, passed = 0, exceptionsNumber = 0;
    //    private static string _testRunResult;

    //    static void Main(string[] args)
    //    {
    //        RunAllListTests();
    //        Console.ReadKey();
    //    }

    //    static void RunAllListTests()
    //    {
    //        RunConstructorsTests();
    //        RunInsertBeginTests();
    //        RunInsertEndTests();
    //        RunIndexOfTests();
    //        RunInsertTests();
    //        RuntRemoveEndTests();
    //        RunRemoveBeginTest();
    //        RunRemoveTests();
    //        RunRemoveAtIndexTests();
    //        RunReverseTests();
    //        RunContainsTests();
    //        RunCountTests();
    //        RunGetLengthTests();
    //        RunMaxTests();
    //        RunAverageTests();
    //        RunSumTests();
    //        RunToArrayTests();
    //        RunEqualsTests();

    //        PrintTestStatistics();
    //    }

    //    private static void RunEqualsTests()
    //    {
    //        RunTest(() =>
    //        {
    //            int[] array = { 1, 2, 3, 4, 5 };
    //            List mylist = new List(array);
    //            List mylist2 = new List(array);
    //            bool equals = mylist.Equals(mylist2);
    //            AssertEqual(equals, true);
    //        }, "Equals of equal lists");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4, 5 });
    //            List mylist2 = new List(new int[] { 1, 2, 3, 4 });
    //            bool equals = mylist.Equals(mylist2);
    //            AssertEqual(equals, false);
    //        }, "Equals of NOT equal lists where second one shorter than first");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4 });
    //            List mylist2 = new List(new int[] { 1, 2, 3, 4, 5 });
    //            bool equals = mylist.Equals(mylist2);
    //            AssertEqual(equals, false);
    //        }, "Equals of NOT equal lists where second one longer than first");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 5, 4, 3, 2 });
    //            List mylist2 = new List(new int[] { 1, 2, 3, 4, 5 });
    //            bool equals = mylist.Equals(mylist2);
    //            AssertEqual(equals, false);
    //        }, "Equals of NOT equal lists");
    //    }

    //    private static void RunToArrayTests()
    //    {
    //        RunTest(() =>
    //        {
    //            int[] array = { 1, 2, 3, 4, 5 };
    //            List mylist = new List(array);
    //            int[] arrayFromList = mylist.ToArray();
    //            AssertEqual(arrayFromList, array);
    //        }, "ToArray of a NOT empty list");

    //        RunTest(() =>
    //        {
    //            int[] array = { };
    //            List mylist = new List(array);
    //            int[] arrayFromList = mylist.ToArray();
    //            AssertEqual(arrayFromList, array);
    //        }, "ToArray of an empty list");
    //    }

    //    private static bool ArraysEquals(int[] array, int[] array2)
    //    {
    //        if (array.Length != array2.Length)
    //            return false;

    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (array[i] != array2[i])
    //                return false;
    //        }
    //        return true;
    //    }
    //    private static void AssertEqual(int[] array1, int[] array2)
    //    {
    //        HandleTestResult(ArraysEquals(array1, array2));
    //    }

    //    private static void RunSumTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 5, 4, 3, 2, 1 });
    //            int average = mylist.Sum();
    //            AssertEqual(average, 15);
    //        }, "Sum of NOT empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { });
    //            int average = mylist.Sum();
    //            AssertEqual(average, 0);
    //        }, "Sum of an empty list");
    //    }

    //    private static void RunAverageTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 5, 4, 3, 2, 1 });
    //            int average = mylist.Average();
    //            AssertEqual(average, 3);
    //        }, "Average of NOT empty list");
    //    }

    //    private static void RunMaxTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 3, 2, 5, 4, 1 });
    //            int max = mylist.Max();
    //            AssertEqual(max, 5);
    //        }, "Max of NOT empty list");
    //    }

    //    private static void RunGetLengthTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 5, 4, 3, 2, 1 });
    //            int length = mylist.GetLength();
    //            AssertEqual(length, 5);
    //        }, "GetLength of a NOT empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { });
    //            int length = mylist.GetLength();
    //            AssertEqual(length, 0);
    //        }, "GetLength of an empty list");
    //    }

    //    private static void RunCountTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 2, 4, 2 });
    //            int count = mylist.Count(2);
    //            AssertEqual(count, 3);
    //        }, "Count an existing item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 2, 4, 2 });
    //            int count = mylist.Count(5);
    //            AssertEqual(count, 0);
    //        }, "Count a NOT existing item");
    //    }


    //    private static void RunContainsTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4 });
    //            bool contains = mylist.Contains(3);
    //            AssertEqual(contains, true);
    //        }, "Contains an existing item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4 });
    //            bool contains = mylist.Contains(5);
    //            AssertEqual(contains, false);
    //        }, "Contains a NOT existing item");
    //    }

    //    private static void RunReverseTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1 });
    //            mylist.Reverse();
    //            AssertEqual(mylist, new int[] { 1 });
    //        }, "Reverse a 1-item list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            mylist.Reverse();
    //            AssertEqual(mylist, new int[] { 3, 2, 1 });
    //        }, "Reverse a NOT empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { });
    //            mylist.Reverse();
    //            AssertEqual(mylist, new int[] { });
    //        }, "Reverse an empty list");
    //    }

    //    private static void RunRemoveAtIndexTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.RemoveAtIndex(0);
    //            AssertEqual(mylist, new int[] { 2, 3 }, removeSuccess, true);
    //        }, "RemoveAtIndex 0");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.RemoveAtIndex(2);
    //            AssertEqual(mylist, new int[] { 1, 2 }, removeSuccess, true);
    //        }, "RemoveAtIndex - the last item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4 });
    //            bool removeSuccess = mylist.RemoveAtIndex(2);
    //            AssertEqual(mylist, new int[] { 1, 2, 4 }, removeSuccess, true);
    //        }, "RemoveAtIndex - 0 < index < length");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.RemoveAtIndex(-1);
    //            AssertEqual(mylist, new int[] { 1, 2, 3 }, removeSuccess, false);
    //        }, "RemoveAtIndex negative index");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.RemoveAtIndex(3);
    //            AssertEqual(mylist, new int[] { 1, 2, 3 }, removeSuccess, false);
    //        }, "RemoveAtIndex - index >= length");
    //    }

    //    private static void RunRemoveTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.Remove(1);
    //            AssertEqual(mylist, new int[] { 2, 3 }, removeSuccess, true);
    //        }, "Remove the first item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.Remove(3);
    //            AssertEqual(mylist, new int[] { 1, 2 }, removeSuccess, true);
    //        }, "Remove the last item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4 });
    //            bool removeSuccess = mylist.Remove(3);
    //            AssertEqual(mylist, new int[] { 1, 2, 4 }, removeSuccess, true);
    //        }, "Remove an existing item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3, 4 });
    //            bool removeSuccess = mylist.Remove(5);
    //            AssertEqual(mylist, new int[] { 1, 2, 3, 4 }, removeSuccess, false);
    //        }, "Remove a NOT existing item");
    //    }

    //    private static void RunRemoveBeginTest()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.RemoveBegin();
    //            AssertEqual(mylist, new int[] { 2, 3 }, removeSuccess, true);
    //        }, "RemoveBegin from NOT empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1 });
    //            bool removeSuccess = mylist.RemoveBegin();
    //            AssertEqual(mylist, new int[] { }, removeSuccess, true);
    //        }, "RemoveBegin from 1-item list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { });
    //            bool removeSuccess = mylist.RemoveBegin();
    //            AssertEqual(mylist, new int[] { }, removeSuccess, false);
    //        }, "RemoveBegin from empty list");
    //    }

    //    private static void RuntRemoveEndTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool removeSuccess = mylist.RemoveEnd();
    //            AssertEqual(mylist, new int[] { 1, 2 }, removeSuccess, true);
    //        }, "RemoveEnd from NOT empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1 });
    //            bool removeSuccess = mylist.RemoveEnd();
    //            AssertEqual(mylist, new int[] { }, removeSuccess, true);
    //        }, "RemoveEnd from 1-item list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { });
    //            bool removeSuccess = mylist.RemoveEnd();
    //            AssertEqual(mylist, new int[] { }, removeSuccess, false);
    //        }, "RemoveEnd from empty list");
    //    }

    //    private static void RunInsertTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool insertSuccess = mylist.Insert(0, 10);
    //            AssertEqual(mylist, new int[] { 1, 10, 2, 3 }, insertSuccess, true);
    //        }, "Insert after first item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 4 });
    //            bool insertSuccess = mylist.Insert(1, 3);
    //            AssertEqual(mylist, new int[] { 1, 2, 3, 4 }, insertSuccess, true);
    //        }, "Insert after 0 <= index < list length");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool insertSuccess = mylist.Insert(2, 4);
    //            AssertEqual(mylist, new int[] { 1, 2, 3, 4 }, insertSuccess, true);
    //        }, "Insert after last item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool insertSuccess = mylist.Insert(3, 4);
    //            AssertEqual(mylist, new int[] { 1, 2, 3 }, insertSuccess, false);
    //        }, "Insert after index >= list length");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2, 3 });
    //            bool insertSuccess = mylist.Insert(-2, 0);
    //            AssertEqual(mylist, new int[] { 1, 2, 3 }, insertSuccess, false);
    //        }, "Insert after negative index");
    //    }

    //    private static void RunIndexOfTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 5, 6, 7, 8 });
    //            int index = mylist.IndexOf(7);
    //            AssertEqual(index, 2);
    //        }, "IndexOf existing item");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 5, 6, 7, 8 });
    //            int index = mylist.IndexOf(1);
    //            AssertEqual(index, -1);
    //        }, "IndexOf NOT existing item");

    //    }

    //    private static void RunInsertEndTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List();
    //            mylist.InsertEnd(1);
    //            AssertEqual(mylist, new int[] { 1 });
    //        }, "InsertEnd to empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 1, 2 });
    //            mylist.InsertEnd(3);
    //            AssertEqual(mylist, new int[] { 1, 2, 3 });
    //        }, "InsertEnd to NOT empty list");

    //    }

    //    private static void RunInsertBeginTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List();
    //            mylist.InsertBegin(1);
    //            AssertEqual(mylist, new int[] { 1 });
    //        }, "InsertBegin to empty list");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(new int[] { 2, 3 });
    //            mylist.InsertBegin(1);
    //            AssertEqual(mylist, new int[] { 1, 2, 3 });
    //        }, "InsertBegin to NOT empty list");
    //    }

    //    private static void RunConstructorsTests()
    //    {
    //        RunTest(() =>
    //        {
    //            List mylist = new List();
    //            AssertEqual(mylist, new int[] { });
    //        }, "empty ctor");

    //        RunTest(() =>
    //        {
    //            List mylist = new List(1);
    //            AssertEqual(mylist, new int[] { 1 });
    //        }, "ctor with 1 int param");

    //        RunTest(() =>
    //        {
    //            int[] array = { 1, 2, 3 };
    //            List mylist = new List(array);
    //            AssertEqual(mylist, array);
    //        }, "ctor from array");
    //    }

    //    static void RunTest(TestCase testCase, string testCaseName)
    //    {
    //        testRuns++;

    //        try
    //        {
    //            testCase();
    //        }
    //        catch
    //        {
    //            exceptionsNumber++;
    //            _testRunResult = "Exception";
    //        }
    //        PrintTestRunResult(_testRunResult, testCaseName);
    //    }

    //    const bool PRINT_JUST_FAILED_TESTS = true;
    //    private static void PrintTestRunResult(string result, string testCaseName)
    //    {
    //        if (PRINT_JUST_FAILED_TESTS && result != "PASS" || !PRINT_JUST_FAILED_TESTS)
    //            Console.WriteLine(result + " - " + testCaseName);
    //    }

    //    static void PrintTestStatistics()
    //    {
    //        Console.WriteLine(new string('_', 80));
    //        double successRate = ((double)passed) / testRuns;
    //        Console.WriteLine("Tests: {0}, Passed: {1}, Exceptions Number: {2}, Success Rate: {3:N2}",
    //            testRuns, passed, exceptionsNumber, successRate);
    //        Console.WriteLine();
    //    }

    //    private static bool Equals(List list, int[] array)
    //    {
    //        ListNode current = list.begin;
    //        int index = 0;
    //        while (current != null && index < array.Length)
    //        {
    //            if (current.value != array[index])
    //                return false;
    //            current = current.next;
    //            index++;
    //        }
    //        if (current == null && index == array.Length)
    //            return true;
    //        else
    //            return false;
    //    }


    //    public static void HandleTestResult(bool testPassed)
    //    {
    //        if (testPassed)
    //            passed++;
    //        _testRunResult = testPassed ? "PASS" : "FAIL";
    //    }

    //    public static void AssertEqual(List list, int[] array)
    //    {
    //        HandleTestResult(Equals(list, array));
    //    }

    //    public static void AssertEqual(List list, int[] array, bool actual, bool expected)
    //    {
    //        HandleTestResult(Equals(list, array) && actual == expected);
    //    }

    //    public static void AssertEqual(int actual, int expected)
    //    {
    //        HandleTestResult(actual == expected);
    //    }

    //    public static void AssertEqual(bool actual, bool expected)
    //    {
    //        HandleTestResult(actual == expected);
    //    }
    //}

    class ListMain
    {
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void RunExample()
        {
            List mylist = new List(new int[] { 1, 2, 3 });
            mylist.Print();
            mylist.InsertBegin(0);
            mylist.Print();
            mylist.InsertEnd(4);
            mylist.Print();
            int index = mylist.IndexOf(3);
            Console.WriteLine(index);
            bool isInsertSuccess = mylist.Insert(3, 10);
            Console.WriteLine(isInsertSuccess);
            mylist.Print();
            mylist.RemoveBegin();
            mylist.Print();
            mylist.Remove(10);
            mylist.Print();
            mylist.RemoveEnd();
            mylist.Print();
            mylist.Reverse();
            mylist.Print();
            bool contains = mylist.Contains(1);
            Console.WriteLine(contains);
            mylist.InsertEnd(2);
            int count = mylist.Count(2);
            Console.WriteLine(count);
            int length = mylist.GetLength();
            Console.WriteLine(length);
            int max = mylist.Max();
            Console.WriteLine(max);
            int avg = mylist.Average();
            Console.WriteLine(avg);
            int sum = mylist.Sum();
            Console.WriteLine(sum);
            int[] array = mylist.ToArray();
            PrintArray(array);

            // list now 3 2 1 2
            List listToCompare = new List(new int[] { 3, 4, 1, 2 });
            bool equals = mylist.Equals(listToCompare);
            Console.WriteLine(equals);

            listToCompare = new List(new int[] { 3, 2, 1, 2 });
            equals = mylist.Equals(listToCompare);
            Console.WriteLine(equals);

            listToCompare = new List(new int[] { 3, 2, 1 });
            equals = mylist.Equals(listToCompare);
            Console.WriteLine(equals);

            listToCompare = new List(new int[] { 3, 2, 1, 2, 5 });
            equals = mylist.Equals(listToCompare);
            Console.WriteLine(equals);

            mylist.RemoveAtIndex(2);
            mylist.Print();
        }
    }
}