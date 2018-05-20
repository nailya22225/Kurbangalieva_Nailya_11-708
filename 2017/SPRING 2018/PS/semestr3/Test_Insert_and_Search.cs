using System;
using SplayTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Splay_tree_Test
{
    [TestClass]
    public class Test_Insert_and_Search
    {
        [TestMethod]
        public void TestInsertAndSearch()
        {
            var arr = new int[] { 30, 70, 15, 50, 5, 60, 85, 10, 20, 35, 40, 55, 65, 80, 90 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);
            var tr = true;
            foreach (var item in arr)
                if (tree.Search(item)==null)
                    tr = false;
            Assert.AreEqual(tr, true);
        }

        [TestMethod]
        public void EmptyTreeDoesNotContainDefaultValue()
        {
            var intTree = new SplayTree<int>();
            var areTrue = true;
            var t = intTree.Search(0);
            if (t == null)
                areTrue = false;
            Assert.IsFalse(areTrue);
            var stringTree = new SplayTree<string>();
            var areTrueString = true;
            var tt = intTree.Search(0);
            if (tt == null)
                areTrueString = false;
            Assert.IsFalse(areTrueString);
        }

        [TestMethod]
        public void NotFailOnStackOverflow()
        {
            var tree = new SplayTree<int>();
            foreach (var e in Enumerable.Range(0, 10000))
            {
                tree.Insert(e);
                tree.Search(e);
            }
        } 
    }
}
