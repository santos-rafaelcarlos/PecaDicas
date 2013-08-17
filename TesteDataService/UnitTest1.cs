using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteDataService.ModelData;
using PecaDicas.Contratos;

namespace TesteDataService
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    ModelData.pecaDicaBDEntities contexto =
        //      new pecaDicaBDEntities(new Uri("http://localhost:63962/DataServices/ModelDataService.svc/"));

        //    contexto.AddObject("Categoria", new Categoria() 
        //    {               
        //        Nome="Arrefecimento",
        //        Id=Guid.NewGuid(),
        //        Descricao="Descrição",
                
                
        //    });
        //    contexto.SaveChanges();

        //}

        [TestMethod]
        public void TestMethod()
        {
           ServiceCategoria.CategoriaServiceClient  contexto =
              new ServiceCategoria.CategoriaServiceClient();

           contexto.Inserir(new PecaDicas.Contratos.Categoria()
           {
               Nome = "Lubrificação",
               ID = Guid.NewGuid(),
               Descricao = "Descrição",
           });           

        }
    }
}
