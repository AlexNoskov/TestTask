using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest_Sequencer
    {
        [TestMethod]
        public void Sequencer_StartState_InitNull()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(null);
            Panel_Sequencer<Int32>.StartState_InitNull(sequencer);
        }

        [TestMethod]
        public void Sequencer_StartState()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(SourceValues_Sequencer_Int.Direct);
            Panel_Sequencer<Int32>.StartState(sequencer, SourceValues_Sequencer_Int.Direct);            
        }

        [TestMethod]
        public void Sequencer_PutOrder_InitNull()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(null);
            Panel_Sequencer<Int32>.PutOrder_InitNull(sequencer);
        }

        [TestMethod]
        public void Sequencer_PutOrder_One()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(SourceValues_Sequencer_Int.One);
            Panel_Sequencer<Int32>.PutOrder(sequencer, SourceValues_Sequencer_Int.One);
        }

        [TestMethod]
        public void Sequencer_PutOrder_Direct()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(SourceValues_Sequencer_Int.Direct);
            Panel_Sequencer<Int32>.PutOrder(sequencer, SourceValues_Sequencer_Int.Direct);
        }

        [TestMethod]
        public void Sequencer_PutOrder_Reverse()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(SourceValues_Sequencer_Int.Reverse);
            Panel_Sequencer<Int32>.PutOrder(sequencer, SourceValues_Sequencer_Int.Direct);
        }

        [TestMethod]
        public void Sequencer_PutOrder_BadPerformance()
        {
            Sequencer<Int32> sequencer = new Sequencer<int>(SourceValues_Sequencer_Int.BadPerformance);
            Panel_Sequencer<Int32>.PutOrder(sequencer, SourceValues_Sequencer_Int.BadPerformance_Direct);
        }        
    }
}
