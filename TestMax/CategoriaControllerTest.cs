using ApiMax.Controllers;
using AspMax.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestMax
{
    class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Contexto> _mockContext;
        private readonly Categoria _categoria;
        public CategoriaControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Contexto>();
            _categoria = new Categoria { id = 1, descricao = "Teste Categoria" };
        }
        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);
            await service.GetCategoria(1);
            _mockSet.Verify(m => m.FindAsync(1),
               Times.Once());
        }
    }
}
