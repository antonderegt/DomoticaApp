﻿using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System; 
using System.Linq;  
  
namespace UnitTestDomoticaApp.UnitTests  {

    [TestClass]      
    public class WP8UnitTest      {
        [TestMethod]          
        [Description("Check to see if MainPage.xaml get instantiated")]     
        public void MainPageTest()          { 
            //Should return true       
            DomoticaApp.MainPage MPage = new DomoticaApp.MainPage();    
            Assert.IsNotNull(MPage);          
    }        
    
    [TestMethod]  
    [Description("Check to see if AddIntegers works as desired")]      
    public void AddIntegers_TwoAndThree_ShouldReturnFive()          {  
    //Should Pass Since we are using Assert.IsTrue and 2+3=5    
        var c=DomoticaApp.MainPage.AddIntegers(2, 3);        
        Assert.IsTrue(c == 5);       
    }         
    
    [TestMethod]      
    [Description("Check to see if AddIntegers works as desired")]   
    public void AddIntegers_TwoAndThree_ShouldNotReturnSeven()          {  
        //Should Pass since we are using Assert.IsFalse and 2+3 does not equal 7  
        var c=DomoticaApp.MainPage.AddIntegers(2, 3);            
        Assert.IsFalse(c == 7);        
    }
    [TestMethod]
    [Description("Check to see if AddIntegers works as desired")]
    public void AddIntegers_ZeroAndMinusOne_ShouldResultMinusOne()
    {
        var c = DomoticaApp.MainPage.AddIntegers(0, -1);
        Assert.IsTrue(c == -1);
    } 
}
}