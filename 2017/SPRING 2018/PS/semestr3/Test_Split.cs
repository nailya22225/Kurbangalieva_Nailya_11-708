using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplayTrees;

namespace Splay_tree_Test
{
    [TestClass]
    public class Test_Split
    {
        [TestMethod]
        public void TestSplit()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);
           
            Tuple<SplayNode<int>,SplayNode<int>> tuple= tree.Split(5);
            Assert.AreEqual(4, tuple.Item1.Value);
            Assert.AreEqual(3, tuple.Item1.Left.Value);
            Assert.AreEqual(2, tuple.Item1.Left.Left.Value);
            Assert.AreEqual(1, tuple.Item1.Left.Left.Left.Value);

            Assert.AreEqual(5, tuple.Item2.Value);
            Assert.AreEqual(10, tuple.Item2.Right.Value);
            Assert.AreEqual(8, tuple.Item2.Right.Left.Value);
            Assert.AreEqual(6, tuple.Item2.Right.Left.Left.Value);
            Assert.AreEqual(9, tuple.Item2.Right.Left.Right.Value);
            Assert.AreEqual(7, tuple.Item2.Right.Left.Left.Right.Value);
        }
    }
}
