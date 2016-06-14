using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryMuffin.Controllers;
using TryMuffin.Models;

namespace TryMuffin.Tests
{
     [TestClass]
    public class TestSuperHumans
    {
         [TestMethod]
         public void GetAllHeroes_ShouldReturnAllHeroes()
         {
             var TestHeroes = GeTestHeroes();
             var controller = new SuperHumansController(TestHeroes);
             var result = controller.GetAllHeroes() as List<MetaHuman>;
             Assert.AreEqual(TestHeroes.Count, result.Count);
         }

         [TestMethod]
         public async Task GetAllHeroesAsync_ShouldReturnAllHeroes()
         {
             var TestHeroes = GeTestHeroes();
             var controller = new SuperHumansController(TestHeroes);
             var result = await controller.GetAllHeroesAsync() as List<MetaHuman>;
             Assert.AreEqual(TestHeroes.Count, result.Count);
         }
         /// <summary>
         /// Test seed method
         /// </summary>
         /// <returns></returns>
         private List<MetaHuman> GeTestHeroes()
         {
             var TestHeroes = new List<MetaHuman>();
             TestHeroes.Add(new MetaHuman { Id = 1, Name = "Batman" });
             TestHeroes.Add(new MetaHuman { Id = 2, Name = "Superman" });
             TestHeroes.Add(new MetaHuman { Id = 2, Name = "Wonder Women" });
             TestHeroes.Add(new MetaHuman { Id = 2, Name = "Flash" });
             
             return TestHeroes;
         }
    }
}
