using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Util;
using System.Reflection;

namespace Alura.Adopet.Testes
{
    public class GeraDocumentacaoTest
    {
        [Fact]
        public void QuandoExistemComandosDeveRetornarDicionarioNaoVazio()
        {
            // arrange 
            Assembly assemblyComOTipoDocComando = Assembly.GetAssembly(typeof(DocComando))!;
            // porque pus o !: como fiz referência ao projeto que contém DocComando, garanto que não é nulo

            // act
            Dictionary<string, DocComando> dicionario = DocumentacaoDoSistema
                .ToDictionary(fromAssembly: assemblyComOTipoDocComando);

            // assert
            Assert.NotNull(dicionario);
            Assert.NotEmpty(dicionario);
            Assert.Equal(4, dicionario.Count);
        }
    }
}
