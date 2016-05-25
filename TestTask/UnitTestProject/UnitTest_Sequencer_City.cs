using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest_Sequencer_City
    {
        [TestMethod]
        public void Sequencer_City_StartState_InitNull()
        {
            Sequencer<String> sequencer = new Sequencer<String>(null);
            Panel_Sequencer<String>.StartState_InitNull(sequencer);
        }

        [TestMethod]
        public void Sequencer_City_StartState()
        {
            Sequencer<String> sequencer = new Sequencer<String>(SourceValues_Sequencer_City.Direct);
            Panel_Sequencer<String>.StartState(sequencer, SourceValues_Sequencer_City.Direct);
        }

        [TestMethod]
        public void Sequencer_City_PutOrder_InitNull()
        {
            Sequencer<String> sequencer = new Sequencer<String>(null);
            Panel_Sequencer<String>.PutOrder_InitNull(sequencer);
        }

        [TestMethod]
        public void Sequencer_City_PutOrder_One()
        {
            Sequencer<String> sequencer = new Sequencer<String>(SourceValues_Sequencer_City.One);
            Panel_Sequencer<String>.PutOrder(sequencer, SourceValues_Sequencer_City.One);
        }

        [TestMethod]
        public void Sequencer_City_PutOrder_Direct()
        {
            Sequencer<String> sequencer = new Sequencer<String>(SourceValues_Sequencer_City.Direct);
            Panel_Sequencer<String>.PutOrder(sequencer, SourceValues_Sequencer_City.Direct);
        }

        [TestMethod]
        public void Sequencer_City_PutOrder_LikeTask()
        {
            Sequencer<String> sequencer = new Sequencer<String>(SourceValues_Sequencer_City.LikeTask);
            Panel_Sequencer<String>.PutOrder(sequencer, SourceValues_Sequencer_City.Direct);
        }
    }
}
