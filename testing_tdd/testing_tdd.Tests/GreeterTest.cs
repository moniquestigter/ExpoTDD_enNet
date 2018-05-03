using System;
using Xunit;
using testing_tdd.CLI;

namespace testing_tdd.Tests{
    public class GreeterTest{
        [Fact]
        public void ShouldSayHelloToMe(){
            Greeter greeter = new Greeter();
            string greeting = greeter.SayHello("Persona");
            Assert.Equal("Hello, Persona!", greeting);
        }

        [Fact]
        public void ShouldGiveMeMyAge(){
            Greeter greeter = new Greeter();
            int age = greeter.GiveAge();
            Assert.Equal(21, age);
        }

        [Fact]
        public void GetYearOfBirth(){
            Greeter greeter = new Greeter();
            int year = greeter.birthYear();
            Assert.Equal(1997, year);
        }
    }
}