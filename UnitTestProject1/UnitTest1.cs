using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using OOD; 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Student s1 = new Student("one", "I am one", 1000, 1000, 1000, 1000, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
        Student s2 = new Student("two", "I am two", 1001, 1001, 1001, 1001, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
        Student s3 = new Student("three", "I am three", 1002, 1002, 1002, 1002, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
        Student s4 = new Student("four", "I am four", 1003, 1003, 1003, 1003, Student.Levels.Novice, Student.Levels.Adept, Student.Levels.Master);
        Student s5 = new Student("five", "I am five", 1004, 1004, 1004, 1004, Student.Levels.Adept, Student.Levels.Novice, Student.Levels.Master);
        Student s6 = new Student("six", "I am six", 1005, 1005, 1005, 1005, Student.Levels.Adept, Student.Levels.Novice, Student.Levels.Master);
        Student s7 = new Student("seven", "I am seven", 1006, 1006, 1006, 1006, Student.Levels.Adept, Student.Levels.Novice, Student.Levels.Master);
        Student s8 = new Student("eight", "I am eight", 1007, 1007, 1007, 1007, Student.Levels.Master, Student.Levels.Adept, Student.Levels.Novice);
        Student s9 = new Student("nine", "I am nine", 1008, 1008, 1008, 1008, Student.Levels.Master, Student.Levels.Adept, Student.Levels.Novice);
        Student s10 = new Student("ten", "I am ten", 1009, 1009, 1009, 1009, Student.Levels.Master, Student.Levels.Adept, Student.Levels.Novice);

        Healing h1 = new Healing("Buda's sigh", "Spirits + 100", Spell.Difficulty.Easy);
        Healing h2 = new Healing("Buda's laugh", "Spirits + 200", Spell.Difficulty.Medium);
        Healing h3 = new Healing("Buda's cry", "Spirits + 300", Spell.Difficulty.Hard);
        Healing h4 = new Healing("Buda's gasp", "Spirits + 100", Spell.Difficulty.Hard);
        Healing h5 = new Healing("Buda's talk", "Spirits + 200", Spell.Difficulty.Easy);
        Healing h6 = new Healing("Buda's cloud", "Spirits + 300", Spell.Difficulty.Medium);
        Transmogrification tr1 = new Transmogrification("Titan's finger", "Size + 100", Spell.Difficulty.Easy);
        Transmogrification tr2 = new Transmogrification("Titan's hand", "Size + 200", Spell.Difficulty.Medium);
        Transmogrification tr3 = new Transmogrification("Titan's leg", "Size + 300", Spell.Difficulty.Hard);
        Transmogrification tr4 = new Transmogrification("Titan's hair", "Size + 100", Spell.Difficulty.Hard);
        Transmogrification tr5 = new Transmogrification("Titan's head", "Size + 200", Spell.Difficulty.Easy);
        Transmogrification tr6 = new Transmogrification("Titan's back", "Size + 300", Spell.Difficulty.Easy);
        Transmogrification tr7 = new Transmogrification("Titan's slash", "Size + 300", Spell.Difficulty.Medium);
        Teleportation tl1 = new Teleportation("Sonic", "X + 100, Y + 100", Spell.Difficulty.Easy);
        Teleportation tl2 = new Teleportation("Supersonic", "X + 200, Y + 200", Spell.Difficulty.Medium);
        Teleportation tl3 = new Teleportation("Light", "X + 300, Y + 300", Spell.Difficulty.Hard);
        Teleportation tl4 = new Teleportation("Splash", "X + 100, Y + 100", Spell.Difficulty.Hard);
        Teleportation tl5 = new Teleportation("Thunder", "X + 200, Y + 200", Spell.Difficulty.Easy);
        Teleportation tl6 = new Teleportation("Cosmo", "X + 300, Y + 300", Spell.Difficulty.Medium);
        Teleportation tl7 = new Teleportation("Gaia", "X + 300, Y + 300", Spell.Difficulty.Easy);
        StudentList sl = new StudentList();
        SpellBook sb = new SpellBook();

        [TestInitialize]
        public void init()
        {
            
            sb.Put(h1);
            sb.Put(h2);
            sb.Put(h3);
            sb.Put(h4);
            sb.Put(h5);
            sb.Put(h6);
            sb.Put(tr1);
            sb.Put(tr2);
            sb.Put(tr3);
            sb.Put(tr4);
            sb.Put(tr5);
            sb.Put(tr6);
            sb.Put(tr7);
            sb.Put(tl1);
            sb.Put(tl2);
            sb.Put(tl3);
            sb.Put(tl4);
            sb.Put(tl5);
            sb.Put(tl6);
            sb.Put(tl7);

            
            sl.Put(s1);
            sl.Put(s2);
            sl.Put(s3);
            sl.Put(s4);
            sl.Put(s5);
            sl.Put(s6);
            sl.Put(s7);
            sl.Put(s8);
            sl.Put(s9);
            sl.Put(s10);
            s1.Spells = sb;
        }
        //Healing
        [TestMethod]
        public void Healing_HealSuccessful()
        {
            h1.HealSuccessful(s1, s2);
            Assert.AreEqual(1101, s2.Spirit);
        }

        [TestMethod]
        public void Healing_HealFailure()
        {
            h1.HealFailure(s1, s2);
            Assert.AreEqual(900, s1.Spirit);
        }

        [TestMethod]
        public void Healing_CastSpellTo_Success()
        {
            h1.CastSpellTo(s1, s2);
            Assert.AreEqual(1101, s2.Spirit);
        }

        [TestMethod]
        public void Healing_CastSpellTo_Failure()
        {
            h3.CastSpellTo(s1, s2);
            Assert.AreEqual(900, s1.Spirit);
        }
        //Teleportation
        [TestMethod]
        public void Teleportation_TeleSuccessful()
        {
            tl1.TeleSuccessful(s1, s2);
            Assert.AreEqual(1201, s2.X);
            Assert.AreEqual(1201, s2.Y);
        }

        [TestMethod]
        public void Teleportation_TeleFailure()
        {
            tl1.TeleFailure(s1, s2);
            Assert.AreEqual(900, s1.Spirit);
        }

        [TestMethod]
        public void Tele_CastSpellTo_Success()
        {
            tl1.CastSpellTo(s1, s2);
            Assert.AreEqual(1201, s2.X);
            Assert.AreEqual(1201, s2.Y);
        }

        [TestMethod]
        public void Tele_CastSpellTo_Failure()
        {
            tl3.CastSpellTo(s1, s2);
            Assert.AreEqual(900, s1.Spirit);
        }
        //Transmogrification
        [TestMethod]
        public void Transmogrification_TeleSuccessful()
        {
            tr1.TransmoSuccessful(s1, s2);
            Assert.AreEqual(1301, s2.Size);
        }

        [TestMethod]
        public void Transmogrification_TeleFailure()
        {
            tr1.TransmoFailure(s1, s2);
            Assert.AreEqual(901, s2.Size);
        }

        [TestMethod]
        public void Tran_CastSpellTo_Success()
        {
            tr1.CastSpellTo(s1, s2);
            Assert.AreEqual(1301, s2.Size);
        }

        [TestMethod]
        public void Tran_CastSpellTo_Failure()
        {
            tr3.CastSpellTo(s10, s2);
            Assert.AreEqual(901, s2.Size);
        }

        [TestMethod]
        public void SpellBook_Fetch()
        {
            Assert.AreEqual("Gaia", sb.Fetch("Gaia").Name);
        }

        [TestMethod]
        public void SpellBook_RandomAssign()
        {
            Assert.AreEqual("Buda's sigh", sb.SpellRandomAssigned(1).Name);
            Assert.AreEqual("Buda's laugh", sb.Spells.ElementAt(1).Name);
        }

        [TestMethod]
        public void SpellBook_Put()
        {
            Assert.AreEqual("Gaia", sb.Spells.Last().Name);
        }

        [TestMethod]
        public void StudentList_Put()
        {
            Assert.AreEqual("ten", sl.Students.Last().Name);
        }

        [TestMethod]
        public void StudentList_Fetch()
        {
            Assert.AreEqual("ten", sl.Fetch("ten").Name);
        }

        [TestMethod]
        public void StudentList_StudentRandomAssigned()
        {

            Assert.AreEqual("one", sl.StudentRandomAssigned(0).Name);
        }

        [TestMethod]
        public void Student_Locate()
        {
            Assert.AreEqual("Gaia", s1.Locate("Gaia").Name);
        }
    }
}
