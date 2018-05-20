using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplayTrees;

namespace Splay_tree_Test
{
    [TestClass]
    public class Test_Remove
    {
        [TestMethod]
        public void TestRemoveOne()
        {
            var arr = new int[] { 30, 70, 15, 50, 5, 60, 85, 10, 20, 35, 40, 55, 65, 80, 90 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);
            tree.Remove(15);
            Assert.AreEqual(null, tree.Search(15));
        }

        [TestMethod]
        public void TestRemoveAll()
        {
            var arr = new int[] { 30, 70, 15, 50, 5, 60, 85, 10, 20, 35, 40, 55, 65, 80, 90 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);
            foreach (var e in arr)
                tree.Remove(e);
            foreach (var e in arr)
                Assert.AreEqual(null, tree.Search(e));
        }
    }
}
