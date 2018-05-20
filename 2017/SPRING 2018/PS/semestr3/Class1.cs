using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplayTrees
{
    public class SplayNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public SplayNode<T> Left { get; set; }
        public SplayNode<T> Right { get; set; }
        public SplayNode<T> Parent { get; set; }

        public SplayNode(T value)
        {
            Value = value;
            Left = Right = Parent = null;
        }
    }

    public class SplayTree<T> where T : IComparable
    {
        public SplayNode<T> root { get; set; }
        /*
        //печатает дерево на экран
        public void preOrder(SplayNode<T> root)
        {
            //сначала печатает корень, затем левую ветку, потом правую ветку
            if (root != null)
            {
                Console.WriteLine(root.Value);
                preOrder(root.Left);
                preOrder(root.Right);
                Console.WriteLine("");
            }
        }*/
        
        //ищет минимальный элемент
        public SplayNode<T> Min(SplayNode<T> localRoot)
        {
            SplayNode<T> minimum = localRoot;
            //спускаемся вниз влево до конца, достаем самый маленький элемент
            while (minimum.Left != null)
            {
                minimum = minimum.Left;
            }
            return minimum;
        }
        //ищет максимальный элемент
        public SplayNode<T> Max(SplayNode<T> localRoot)
        {
            SplayNode<T> maximum = localRoot;
            //спускаемся вниз вправо до конца, достаем самый большой элемент
            while (maximum.Right != null)
            {
                maximum = maximum.Right;
            }
            return maximum;
        }
        //поиск элемента
        public SplayNode<T> Search(T key)
        {
            SplayNode<T> searchedElement = root;
            while (searchedElement != null)
            {
                //если искомый элемент больше корня, спускаемся в правое поддерево
                if (searchedElement.Value.CompareTo(key) < 0)
                {
                    searchedElement = searchedElement.Right;
                }
                //если искомый элемент меньше корня, спускаемся в левое поддерево
                else if (searchedElement.Value.CompareTo(key) > 0)
                {
                    searchedElement = searchedElement.Left;
                }
                //если искомый элемент равен корню, поворачиваем дерево так, что бы искомый элемент стал на место корня и выводим его
                else if (searchedElement.Value.CompareTo(key) == 0)
                {
                    Splay(searchedElement);
                    return searchedElement;
                }
            }
            //если нет такого элемента выводим null
            return null;
        }
        //левый поворот
        public void LeftRotate(SplayNode<T> localRoot)
        {
            //элемент, который в конце должен оказаться на месте корня
            SplayNode<T> rightChild = localRoot.Right;
            if (rightChild != null)
            {
                //левое поддерево нужного элемента становится правым поддеревом текущего корня
                localRoot.Right = rightChild.Left;
                //ставим ссылку на родителя, если есть элементы в левом поддереве нужного элемента
                if (rightChild.Left != null)
                {
                    rightChild.Left.Parent = localRoot;
                }
                //элемент, который в конце должен оказаться на месте корня, становится выше текущего корня
                rightChild.Parent = localRoot.Parent;
            }
            //если текущий корень был корнем всего дерева, то элемент, который в конце должен оказаться на месте корня, становится на место корня
            if (localRoot.Parent == null) root = rightChild;
            //если текущий корень был левым сыном, то элемент, который в конце должен оказаться на месте корня становится левым сыном
            else if (localRoot == localRoot.Parent.Left) localRoot.Parent.Left = rightChild;
            //если текущий корень был правым сыном, то элемент, который в конце должен оказаться на месте корня становится правым сыном
            else if (localRoot == localRoot.Parent.Right) localRoot.Parent.Right = rightChild;
            //текущий корень становится левым сыном элемента, который в конце должен оказаться на месте корня
            if (rightChild != null)
            {
                rightChild.Left = localRoot;
            }
            localRoot.Parent = rightChild;
        }
        //правый поворот
        public void RightRotate(SplayNode<T> localRoot)
        {
            //элемент, который в конце должен оказаться на месте корня
            SplayNode<T> leftChild = localRoot.Left;
            if (leftChild != null)
            {
                //правое поддерево нужного элемента становится левым поддеревом текущего корня
                localRoot.Left = leftChild.Right;
                //ставим ссылку на родителя, если есть элементы в правом поддереве нужного элемента
                if (leftChild.Right != null)
                {
                    leftChild.Right.Parent = localRoot;
                }
                //элемент, который в конце должен оказаться на месте корня, становится выше текущего корня
                leftChild.Parent = localRoot.Parent;
            }
            //если текущий корень был корнем всего дерева, то элемент, который в конце должен оказаться на месте корня, становится на место корня
            if (localRoot.Parent == null) root = leftChild;
            //если текущий корень был левым сыном, то элемент, который в конце должен оказаться на месте корня становится левым сыном
            else if (localRoot == localRoot.Parent.Left) localRoot.Parent.Left = leftChild;
            //если текущий корень был правым сыном, то элемент, который в конце должен оказаться на месте корня становится правым сыном
            else if (localRoot == localRoot.Parent.Right) localRoot.Parent.Right = leftChild;
            //текущий корень становится правым сыном элемента, который в конце должен оказаться на месте корня
            if (leftChild != null)
            {
                leftChild.Right = localRoot;
            }
            localRoot.Parent = leftChild;
        }
       
        public void Transplat(SplayNode<T> localParent, SplayNode<T> localChild)
        {
            if (localParent.Parent == null) root = localChild;
            else if (localParent == localParent.Parent.Left) localParent.Parent.Left = localChild;
            else if (localParent == localParent.Parent.Right) localParent.Parent.Right = localChild;

            if (localChild != null)
            {
                localChild.Parent = localParent.Parent;
            }
        }
       
        public void Splay(SplayNode<T> pivotElement)
        {
            //пока элемент не встанет на место корня, выполняем повороты, в зависимости от того, как расположен элемент в дереве           
            while (pivotElement.Parent != null)
            {
                //если элемент один из сыновей корня
                if (pivotElement.Parent.Parent == null)
                {
                    //если элемент левый сын, делаем правый поворот и он становится на место корня, а его отец становится правым сыном
                    if (pivotElement == pivotElement.Parent.Left) RightRotate(pivotElement.Parent);
                    //если элемент правый сын, делаем левый поворот и элемент становится на место корня, а его отец становится левым сыном
                    else if (pivotElement == pivotElement.Parent.Right) LeftRotate(pivotElement.Parent);
                }


                //если элемент, его отец и дедушка лежат на одной ветке, то делаем два правых или два левых поворота
                //zig-zig
                //если они все лежат на левой ветке делам два правых поворота для отца и дедушки
                else if (pivotElement == pivotElement.Parent.Left && pivotElement.Parent == pivotElement.Parent.Parent.Left)
                {
                    //после первого правого поворота элемент становится на место своего отца, а отец становится правым сыном элемента
                    RightRotate(pivotElement.Parent.Parent);
                    //после второго правого поворота элемент становится на место дедушки
                    RightRotate(pivotElement.Parent);
                }
                //если они лежат на правой ветке делаем два левых поворота для отца и дедушки
                else if (pivotElement == pivotElement.Parent.Right && pivotElement.Parent == pivotElement.Parent.Parent.Right)
                {
                    //после первого левого поворота элемент становится отцом своего отца, а отец, левым сыном элемента
                    LeftRotate(pivotElement.Parent.Parent);
                    //после второго левого поворота, элемент становится на место дедушки
                    LeftRotate(pivotElement.Parent);
                }
                //zig-zag
                //если элемент-правый сын левого сына, делаем сначала левый поворот для отца, зател правй поворот для дедушки
                else if (pivotElement == pivotElement.Parent.Right && pivotElement.Parent == pivotElement.Parent.Parent.Left)
                {
                    //после левого поворота элемент становится отцом своего отца, а отец левым сыном элемента
                    LeftRotate(pivotElement.Parent);
                    // элемент, его отец и дедушка лежат на левой ветке, делаем один правй поворот, т.к. элемент находится между отцом и дедушкой,
                    //в итоге становится на место своего дедушки
                    RightRotate(pivotElement.Parent);
                }
                //если элемент-левый сын правого сына, то делаем сначала правый поворот для отца, затем левый поворот для дедушки
                else if (pivotElement == pivotElement.Parent.Left && pivotElement.Parent == pivotElement.Parent.Parent.Right)
                {
                    //после правого поворота элемент становится отцом своего отца, а отец правым сыном элемента
                    RightRotate(pivotElement.Parent);
                    // элемент, его отец и дедушка лежат на правой ветке, делаем один левый поворот, т.к. элемент находится между отцом и дедушкой,
                    //в итоге становится на место своего дедушки
                    LeftRotate(pivotElement.Parent);
                }
            }
        }


        //вставка нового элемента
        public void Insert(T key)
        {
            //переменная для поиска места родителя вставляемого элемента
            SplayNode<T> preInsertPlace = null;
            //переменная для поиска места вставки элемента
            SplayNode<T> insertPlace = root;
            //ищем место для нового элемента
            while (insertPlace != null)
            {
                preInsertPlace = insertPlace;
                //если элемент больше или равен корню, спускаемся в правое поддерево
                if (insertPlace.Value.CompareTo(key) <= 0)
                {
                    insertPlace = insertPlace.Right;
                }
                //если элемент меньше корня спускаемся в левое поддерево
                else if (insertPlace.Value.CompareTo(key) > 0)
                {
                    insertPlace = insertPlace.Left;
                }
            }
            //создаем новый элемент
            SplayNode<T> insertElement = new SplayNode<T>(key);
            //родитель
            insertElement.Parent = preInsertPlace;
            //если предыдущего элемента нет, то вставляемый элемент-корень дерева
            if (preInsertPlace == null)
            {
                root = insertElement;
            }
            //если новый элемент не меньше своего родителя, то он правый сын
            else if (preInsertPlace.Value.CompareTo(insertElement.Value) < 0)
            {
                preInsertPlace.Right = insertElement;
            }
            //если новый элемент меньше своего родителя, то он левый сын
            else if (preInsertPlace.Value.CompareTo(insertElement.Value) > 0)
            {
                preInsertPlace.Left = insertElement;
            }
            //поворачиваем дерево так, что бы вставляемый элемент встал на место корня
            Splay(insertElement);
        }

        //удаление элемента
        public void Remove(T key)
        {
            //ищем элемент в дереве
            SplayNode<T> removeElement = Search(key);
            if (removeElement != null)
            {
                //поворачиваем дерево так, что бы удаляемый элемент встал на место корня


                if (removeElement.Right == null) Transplat(removeElement, removeElement.Left); //?
                else if (removeElement.Left == null) Transplat(removeElement, removeElement.Left); //?
                else
                {
                    //новый корень-минимальный элемент, который больше удаляемого элемента
                    SplayNode<T> newLocalRoot = Min(removeElement.Right);
                    if (newLocalRoot.Parent != removeElement)
                    {
                        Transplat(newLocalRoot, newLocalRoot.Right);
                        //правая ветка у нового корня такая же как и правая ветка удаляемого элемента
                        newLocalRoot.Right = removeElement.Right;
                        newLocalRoot.Right.Parent = newLocalRoot;
                    }
                    Transplat(removeElement, newLocalRoot);
                    //левая ветка у нового корня такая же как и левая ветка удаляемого элемента
                    newLocalRoot.Left = removeElement.Left;
                    newLocalRoot.Left.Parent = newLocalRoot;
                    Splay(newLocalRoot);
                }
            }
        }
        //разделение дерева
        public Tuple<SplayNode<T>, SplayNode<T>> Split(T key)
        {
            //разделяемый элемент
            SplayNode<T> element = SearchDivideElement(key);
            //поворачиваем дерево так, что бы разделяемый элемент встал на место корня
            Splay(element);
            SplayNode<T> item21 = element.Left;
            if (element != null)
            {
                element.Left.Parent = null;
                
                element.Left = null;
            }
            return new Tuple<SplayNode<T>, SplayNode<T>>(item21, element);
        }
        public SplayNode<T> SearchDivideElement(T key)
        {
            SplayNode<T> searchedElement = root;
            while (searchedElement != null)
            {
                //если искомый элемент больше корня, спускаемся в правое поддерево, если правее никого нет и мы дошли до конца, 
                if (searchedElement.Value.CompareTo(key) < 0)
                {
                    searchedElement = searchedElement.Right;
                    if (searchedElement.Right == null) return searchedElement;
                }
                //если искомый элемент меньше корня, спускаемся в левое поддерево, если левее никого нет, то берем наименьший элемент, больший данному
                else if (searchedElement.Value.CompareTo(key) > 0)
                {
                    searchedElement = searchedElement.Left;
                    if (searchedElement.Left == null) return searchedElement;
                }
                //если искомый элемент равен корню, поворачиваем дерево так, что бы искомый элемент стал на место корня и выводим его
                else if (searchedElement.Value.CompareTo(key) == 0)
                {
                    Splay(searchedElement);
                    return searchedElement;
                }
            }
            //если нет такого элемента выводим null
            return null;
        }
        //объединение двух деревьев
        public SplayTree<T> Merge(SplayTree<T> tree11, SplayTree<T> tree22)
        {
            var tree1 = new SplayTree<T>();
            var tree2 = new SplayTree<T>();
            //ищем максимальные и минимальные элементы деревьев
            var min1 = Min(tree11.root);
            var max1 = Max(tree11.root);
            var min2 = Min(tree22.root);
            var max2 = Max(tree22.root);
            //Для корректной работы,все ключи одного дерева должны быть меньше всех ключей другого дерева
            //если самый маленький элемент 1 дерева больше самого болшого элемента 2 дерева
            //то все ключи 2 дерева меньше всех ключей 1 дерева
            if (min1.Value.CompareTo(max2.Value) > 0)
            {
                tree1 = tree22;
                tree2 = tree11;
            }
            //если самый маленький элемент 2 дерева больше самого болшого элемента 1 дерева
            //то все ключи 1 дерева меньше всех ключей 2 дерева
            else if (min2.Value.CompareTo(max1.Value) > 0)
            {
                tree1 = tree11;
                tree2 = tree22;
            }
            //иначе нельзя соеденить эти деревья
            else
            {
                return null;
            }
                //находим наибольший элемент 1 дерева
                SplayNode<T> element = Max(tree1.root);
            
                //поворачиваем дерево так что бы все его элементы были в левой ветке
                Splay(element);
                //правой веткой 1 дерева становится 2 дерево
                element.Right = tree2.root;
                //родитель 2 дерева-наибольший желемент 1 дерева
                tree22.root.Parent = element;
            
            return tree1;
        }
    }
}

