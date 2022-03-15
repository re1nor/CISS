using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem
{
    class SingleList<TreeNode> 
    {
        public SingleNode<TreeNode> top;
        public int Count { get; set; }     //количество элементов(узлов) в списке
        //public int Count { get { return Count; } }

        public SingleList()
        {
            top = null;
        }

        public SingleList(SingleNode<TreeNode> t)
        {
            top = t;
        }

        //Добавление узла в начало
        public void AddTop(int k, TreeNode v)
        {
            SingleNode<TreeNode> new_node = new SingleNode<TreeNode>(k, v);

            if (top == null)
                top = new_node;
            else
                new_node.Next = top;
            top = new_node;

            Count++;
        }

        //Добавление узла в конец
        public void AddEnd(int k, TreeNode v)
        {
            SingleNode<TreeNode> new_node = new SingleNode<TreeNode>(k, v);

            if (top == null)
            {
                //top = new_node;
                AddTop(k, v);
            }
            else
            {
                SingleNode<TreeNode> current = top;
                // ищем последний элемент
                while (current.Next != null)
                {
                    current = current.Next;
                }
                //устанавливаем последний элемент
                current.Next = new_node;
            }
            Count++;
        }

        //Удаление первого узла из односвязного списка
        public void RemoveTop()
        {
            if (Count > 0)
            {
                top = top.Next;
                Count--;
                return;
            }
        }

        //Удаление последнего узла из односвязного списка
        public void RemoveEnd()
        {
            if (Count > 0)
            {
                if (Count == 1)
                {
                    top = null; Count = 0; return;
                }

                SingleNode<TreeNode> tmp = top;

                //Найдем предпоследний узел
                while (tmp.Next.Next != null)        //tmp.Next.Next - предпоследний узел
                {
                    tmp = tmp.Next;
                }
                tmp.Next = null;
                Count--;
            }
        }

        //Проверка на наличие элемента в односвязном списке
        public bool IsContainsByValue(TreeNode value)
        {
            SingleNode<TreeNode> tmp = top;
            while (tmp != null)
            {
                if (tmp.Value.Equals(value))
                    return true;
                tmp = tmp.Next;
            }
            return false;
        }

        public void View()
        {
            Console.WriteLine("===================");
            SingleNode<TreeNode> current = top;
            // ищем последний элемент
            while (current != null)
            {
                Console.WriteLine("{0} => ", current);
                

                current = current.Next;
            }
            
            Console.WriteLine();
            
            
        }

        //Поиск по значению
        public SingleNode<TreeNode> FindByValue(TreeNode value)
        {
            SingleNode<TreeNode> tmp = top;
            while (tmp != null)
            {
                if (tmp.Value.Equals(value))
                    return tmp;
                tmp = tmp.Next;
            }
            return null;
        }

        //Поиск по индексу
        public SingleNode<TreeNode> FindByIndex(int index)
        {
            int i = 0;
            SingleNode<TreeNode> tmp = top;
            if (index < 0 || index >= Count) return null;
            while (tmp != null)
            {
                if (i == index) { return tmp; }
                tmp = tmp.Next;
                i++;
            }
            return null;
        }

        //Поиск по ключу
        public SingleNode<TreeNode> FindByKey(int key)
        {
            SingleNode<TreeNode> tmp = top;
            while (tmp != null)
            {
                if (tmp.Key.Equals(key))
                    return tmp;
                tmp = tmp.Next;
            }
            return null;
        }

        //Вставка нового узла после выбранного узла
        public void InsertByAfterValue(TreeNode select, int key, TreeNode value)
        {
            SingleNode<TreeNode> after_me = top;
            while (after_me != null)
            {
                if (after_me.Value.Equals(select))
                {
                    //FindByValue(value);
                    SingleNode<TreeNode> nn = new SingleNode<TreeNode>(key, value)
                    {
                        Next = after_me.Next
                    };
                    after_me.Next = nn;

                }
                after_me = after_me.Next;
                Count++;
            }
        }

        //Вставка нового узла перед выбранным узлом
        public void InsertByBeforeValue(TreeNode select, int key, TreeNode value)
        {
            SingleNode<TreeNode> current = top;
            SingleNode<TreeNode> before_me = null;
            while (current != null)
            {
                if (current.Value.Equals(select))
                {
                    SingleNode<TreeNode> nn = new SingleNode<TreeNode>(key, value)
                    {
                        Next = current
                    };
                    if (before_me != null)
                    {
                        before_me.Next = nn;
                    }
                    else top = nn;
                }
                before_me = current;
                current = current.Next;
                Count++;
            }
        }

        //Удаление узла по значению
        public bool RemoveByValue(TreeNode value)
        {
            SingleNode<TreeNode> current = top;
            SingleNode<TreeNode> previous = null;  //Для отслеживания предыдущего узла применяется переменная previous

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение top
                        top = top.Next;
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        //Удаление узла по индексу
        public bool RemoveByIndex(int index)
        {
            int i = 0;
            SingleNode<TreeNode> current = top;
            SingleNode<TreeNode> previous = null;  //Для отслеживания предыдущего узла применяется переменная previous

            if (index < 0 || index >= Count) return false;

            while (current != null)
            {
                if (i == index)
                {
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение top
                        top = top.Next;
                    }
                    Count--;
                    return true;
                }
                i++;
                previous = current;
                current = current.Next;
            }
            return false;
        }

        //Удаление узла по ключу
        public bool RemoveByKey(int key)
        {
            SingleNode<TreeNode> current = top;
            SingleNode<TreeNode> previous = null;  //Для отслеживания предыдущего узла применяется переменная previous

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение top
                        top = top.Next;
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
    }
}
