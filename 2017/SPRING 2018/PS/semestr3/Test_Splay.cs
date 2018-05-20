using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplayTrees;

namespace Splay_tree_Test
{
    [TestClass]
    public class Test_Splay
    {
        [TestMethod]
        public void SplayForRoot()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);

            tree.Splay(tree.root);
            Assert.AreEqual(10, tree.root.Value);
            Assert.AreEqual(9, tree.root.Left.Value);
            Assert.AreEqual(8, tree.root.Left.Left.Value);
            Assert.AreEqual(7, tree.root.Left.Left.Left.Value);
            Assert.AreEqual(6, tree.root.Left.Left.Left.Left.Value);
            Assert.AreEqual(5, tree.root.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(4, tree.root.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(3, tree.root.Left.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(2, tree.root.Left.Left.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(1, tree.root.Left.Left.Left.Left.Left.Left.Left.Left.Left.Value);
        }
        [TestMethod]
        public void Splay_Zig()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);

            tree.Splay(tree.root.Left);
            Assert.AreEqual(9, tree.root.Value);
            Assert.AreEqual(8, tree.root.Left.Value);
            Assert.AreEqual(7, tree.root.Left.Left.Value);
            Assert.AreEqual(6, tree.root.Left.Left.Left.Value);
            Assert.AreEqual(5, tree.root.Left.Left.Left.Left.Value);
            Assert.AreEqual(4, tree.root.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(3, tree.root.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(2, tree.root.Left.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(1, tree.root.Left.Left.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(10, tree.root.Right.Value);
            
            var arr2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var tree2 = new SplayTree<int>();
            foreach (var e in arr2)
                tree2.Insert(e);

            tree2.Splay(tree2.root.Right);
            Assert.AreEqual(2, tree2.root.Value);
            Assert.AreEqual(3, tree2.root.Right.Value);
            Assert.AreEqual(4, tree2.root.Right.Right.Value);
            Assert.AreEqual(5, tree2.root.Right.Right.Right.Value);
            Assert.AreEqual(6, tree2.root.Right.Right.Right.Right.Value);
            Assert.AreEqual(7, tree2.root.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(8, tree2.root.Right.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(9, tree2.root.Right.Right.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(10, tree2.root.Right.Right.Right.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(1, tree2.root.Left.Value);
        }
        [TestMethod]
        public void Splay_ZigZig()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);

            tree.Splay(tree.root.Left.Left);
            Assert.AreEqual(8, tree.root.Value);
            Assert.AreEqual(7, tree.root.Left.Value);
            Assert.AreEqual(6, tree.root.Left.Left.Value);
            Assert.AreEqual(5, tree.root.Left.Left.Left.Value);
            Assert.AreEqual(4, tree.root.Left.Left.Left.Left.Value);
            Assert.AreEqual(3, tree.root.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(2, tree.root.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(1, tree.root.Left.Left.Left.Left.Left.Left.Left.Value);
            Assert.AreEqual(9, tree.root.Right.Value);
            Assert.AreEqual(10, tree.root.Right.Right.Value);
            
            var arr2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var tree2 = new SplayTree<int>();
            foreach (var e in arr2)
                tree2.Insert(e);

            tree2.Splay(tree2.root.Right.Right);
            Assert.AreEqual(3, tree2.root.Value);
            Assert.AreEqual(4, tree2.root.Right.Value);
            Assert.AreEqual(5, tree2.root.Right.Right.Value);
            Assert.AreEqual(6, tree2.root.Right.Right.Right.Value);
            Assert.AreEqual(7, tree2.root.Right.Right.Right.Right.Value);
            Assert.AreEqual(8, tree2.root.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(9, tree2.root.Right.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(10, tree2.root.Right.Right.Right.Right.Right.Right.Right.Value);
            Assert.AreEqual(2, tree2.root.Left.Value);
            Assert.AreEqual(1, tree2.root.Left.Left.Value);
            
        }
        [TestMethod]
        public void Splay_ZigZag()
        {
            var arr = new int[] { 7, 4, 3, 5, 1, 8 };
            var tree = new SplayTree<int>();
            foreach (var e in arr)
                tree.Insert(e);

            tree.Splay(tree.root.Left.Right);
            Assert.AreEqual(7, tree.root.Value);
            Assert.AreEqual(3, tree.root.Left.Value);
            Assert.AreEqual(1, tree.root.Left.Left.Value);
            Assert.AreEqual(5, tree.root.Left.Right.Value);
            Assert.AreEqual(4, tree.root.Left.Right.Left.Value);
            Assert.AreEqual(8, tree.root.Right.Value);

            tree.Splay(tree.root.Left.Right.Left);
            Assert.AreEqual(4, tree.root.Value);
            Assert.AreEqual(3, tree.root.Left.Value);
            Assert.AreEqual(1, tree.root.Left.Left.Value);
            Assert.AreEqual(7, tree.root.Right.Value);
            Assert.AreEqual(8, tree.root.Right.Right.Value);
            Assert.AreEqual(5, tree.root.Right.Left.Value);
        }
    }
}
