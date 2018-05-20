using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplayTrees;

namespace Splay_tree_Test
{
    [TestClass]
    public class Test_Merge
    {
        [TestMethod]
        public void MergeTrees()
        {
            var arr1 = new int[] { 10, 15, 7, 5, 29, 6, 14, 26, 4, 1, 8, 21, 23, 19, 20, 13, 11 };
            var tree1 = new SplayTree<int>();
            foreach (var e in arr1)
                tree1.Insert(e);

            var arr2 = new int[] { 30, 70, 45, 50, 56, 60, 85, 101, 201, 35, 40, 55, 65, 80, 90 };
            var tree2 = new SplayTree<int>();
            foreach (var e in arr2)
                tree2.Insert(e);

            tree1.Merge(tree1, tree2);


            var tr = true;
            foreach (var item in arr1)
                if (tree1.Search(item) == null)
                    tr = false;
            Assert.AreEqual(tr, true);
            ;
            foreach (var item in arr2)
                if (tree1.Search(item) == null)
                    tr = false;
            Assert.AreEqual(tr, true);
        }

        [TestMethod]
        public void DoesNotMergeTwoTrees()
        {
            var arr1 = new int[] { 10, 15, 7, 5, 29, 6, 14, 26, 4, 1, 8, 21, 23, 19, 20, 13, 11 };
            var tree1 = new SplayTree<int>();
            foreach (var e in arr1)
                tree1.Insert(e);

            var arr2 = new int[] { 30, 70, 4, 50, 56, 60, 5, 101, 201, 35, 40, 55, 65, 80, 90 };
            var tree2 = new SplayTree<int>();
            foreach (var e in arr2)
                tree2.Insert(e);

            tree1.Merge(tree1, tree2);

            var tr = true;
            foreach (var item in arr1)
                if (tree1.Search(item) == null)
                    tr = false;
            Assert.AreEqual(tr, true);
            ;
            foreach (var item in arr2)
                if (tree1.Search(item) == null)
                    tr = false;
            Assert.AreEqual(tr, false);
        }
    }
}