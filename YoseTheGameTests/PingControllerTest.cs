using System;
using System.Collections;
using System.Globalization;
using NUnit.Framework;
using System.Collections.Generic;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{

    /// <summary>
    /// Classe de test pour le service Web de ping.
    /// </summary>
    [TestFixture]
    public class PingControllerTest
    {

#region "Members"

        private PingController m_Target;

#endregion


#region "Methods"

        /// <summary>
        /// Survient avant l'exécution de chaque test.
        /// </summary>
        [SetUp] public void SetUp()
        {
            m_Target = new PingController();
        }

        /// <summary>
        /// Survient après l'exécution de chaque test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
        }

#endregion

#region "Tests"

#region "PingController"

        /// <summary>
        /// Un test pour le service Web de Ping.
        /// </summary>
        [Test]
        public void PingController_Valid()
        {
            //Préparation

           // m_Target.

            //Exécution
            //m_Target.
            //actual = target.PrimeFactorsOf(10);

            //Validation
            //Assert.That(Is.EqualTo(expected), target.PrimeFactorsOf(10));
        }

#endregion

#endregion

    }
}