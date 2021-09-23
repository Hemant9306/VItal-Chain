using GameTwist.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwist.TestCases
{
    class ApiTest
    {

        [Test]
        [Order(0)]
        public void CreateUserPost()
        {
            CommanFunction comman = new CommanFunction();
            Assert.IsTrue(comman.PostLoginAPI());
        }

        [Test]
        [Order(1)]
        public void UpdateUser()
        {
            CommanFunction comman = new CommanFunction();
            Assert.IsTrue(comman.PutUserAPI());
        }

        [Test]
        [Order(2)]
        public void GetUser()
        {
            CommanFunction comman = new CommanFunction();
            Assert.IsTrue(comman.GetUserAPI());
        }

        [Test]
        [Order(3)]

        public void DeleteUser()
        {
            CommanFunction comman = new CommanFunction();
            Assert.IsTrue(comman.DeleteUserAPI());
        }

        [Test]
        [Order(4)]
        public void GetUser4X()
        {
            CommanFunction comman = new CommanFunction();
            Assert.IsTrue(comman.GetUserAPIError());
        }


    }
}
