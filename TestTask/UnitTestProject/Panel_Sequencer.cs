using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace UnitTestProject
{
    public class Panel_Sequencer<TLabel>
    {
        public static void StartState_InitNull(Sequencer<TLabel> sequencer)
        {
            AssertEmpty(sequencer);
        }
        
        public static void StartState(Sequencer<TLabel> sequencer, IList<Pair<TLabel>> etalon)
        {
            CollectionAssert.AreEqual(etalon.ToList(), sequencer.Input.ToList());

            Assert.IsNotNull(sequencer.Ordered);
            Assert.IsNotNull(sequencer.NotOrdered);

            Assert.IsTrue(sequencer.Ordered.Count == 0);
            CollectionAssert.AreEqual(etalon.ToList(), sequencer.NotOrdered.ToList());
        }
        
        public static void PutOrder_InitNull(Sequencer<TLabel> sequencer)
        {
            sequencer.PutOrder();
            AssertEmpty(sequencer);
        }
       
        public static void PutOrder(Sequencer<TLabel> sequencer, List<Pair<TLabel>> etalon)
        {            
            CheckSerial(etalon);
            sequencer.PutOrder();
            AssertOrder(sequencer, etalon);
        }
               
        private static void CheckSerial(IList<Pair<TLabel>> serializedList)
        {
            Assert.IsNotNull(serializedList);

            if (serializedList.Count > 1)
            {
                Int32 lastIndex = serializedList.Count - 1;
                for (Int32 i = 0; i < lastIndex; i++)
                {
                    Pair<TLabel> current = serializedList[i];
                    Pair<TLabel> next = serializedList[i + 1];
                    Assert.IsTrue(current.End.Equals(next.Start));
                }
            }
        }

        private static void AssertEmpty(Sequencer<TLabel> serial)
        {
            Assert.IsNotNull(serial.Input);
            Assert.IsTrue(serial.Input.Count == 0);

            Assert.IsNotNull(serial.Ordered);
            Assert.IsNotNull(serial.NotOrdered);

            Assert.IsTrue(serial.Ordered.Count == 0);
            Assert.IsTrue(serial.NotOrdered.Count == 0);
        }

        private static void AssertOrder(Sequencer<TLabel> serial, List<Pair<TLabel>> etalon)
        {
            Assert.IsNotNull(serial.Ordered);
            Assert.IsNotNull(serial.NotOrdered);

            Assert.IsTrue(serial.NotOrdered.Count == 0);
            CollectionAssert.AreEqual(etalon, serial.Ordered.ToList());
        }
    }
}
