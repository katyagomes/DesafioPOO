using Xunit;
using DesafioPOO.Models;
using System;
using System.IO;

namespace DesafioPOO.Tests
{
    public class SmartphoneTests
    {
        // TESTE 1: Verifica se o Nokia é criado corretamente e herda de Smartphone
        [Fact]
        public void DeveCriarInstanciaDeNokiaCorretamente()
        {
            // Arrange (Preparação)
            string numero = "123456";
            string modelo = "Modelo Nokia Tijolão";
            string imei = "111111111";
            int memoria = 64;

            // Act (Ação)
            Smartphone nokia = new Nokia(numero, modelo, imei, memoria);

            // Assert (Validação)
            Assert.NotNull(nokia); // Verifica se não é nulo
            Assert.Equal(numero, nokia.Numero); // Verifica se o número foi gravado
        }

        // TESTE 2: Verifica se o Iphone é criado corretamente
        [Fact]
        public void DeveCriarInstanciaDeIphoneCorretamente()
        {
            // Arrange
            string numero = "987654";
            string modelo = "iPhone 15";
            string imei = "222222222";
            int memoria = 128;

            // Act
            Smartphone iphone = new Iphone(numero, modelo, imei, memoria);

            // Assert
            Assert.NotNull(iphone);
            Assert.Equal(numero, iphone.Numero);
        }

        // TESTE 3: Verifica se o método InstalarAplicativo do Nokia escreve a mensagem certa
        [Fact]
        public void Nokia_DeveExibirMensagemCorretaAoInstalarApp()
        {
            // Arrange
            Smartphone nokia = new Nokia("123", "Modelo 1", "111", 64);
            string appNome = "Whatsapp";
            
            // Truque para capturar o Console.WriteLine
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            nokia.InstalarAplicativo(appNome);

            // Assert
            var resultadoTexto = output.ToString();
            Assert.Contains($"Instalando o aplicativo \"{appNome}\" no Nokia", resultadoTexto);
        }

        // TESTE 4: Verifica se o método InstalarAplicativo do Iphone escreve a mensagem certa
        [Fact]
        public void Iphone_DeveExibirMensagemCorretaAoInstalarApp()
        {
            // Arrange
            Smartphone iphone = new Iphone("456", "Modelo 2", "222", 128);
            string appNome = "Telegram";

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            iphone.InstalarAplicativo(appNome);

            // Assert
            var resultadoTexto = output.ToString();
            Assert.Contains($"Instalando o aplicativo \"{appNome}\" no iPhone", resultadoTexto);
        }
    }
}
