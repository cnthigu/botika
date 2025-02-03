using System;
using System.Linq;
using System.Threading;
using EasyAutomationFramework;
using OpenQA.Selenium;

namespace Ikariambot
{
    public class ikaboattack : Web
    {
        private IWebDriver webDriver;

        private IWebDriver Driver => this.webDriver;


        public void SendAttack(string xpath, int coordenadaX, int coordenadaY, int quantidadeHoplita, int quantidadeCatapulta)
        {
            var startnavegador = StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\HIGORV\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://lobby.ikariam.gameforge.com/pt_BR/hub");
            WaitForLoad();

            var botaoLogar = AssignValue(TypeElement.Xpath, "//*[@id=\"joinGame\"]/a/button", "", 15);
            botaoLogar.element.Click();

            Thread.Sleep(4000);

            var botaoEntrar = AssignValue(TypeElement.Xpath, "//*[@id=\"accountlist\"]/div/div[1]/div[2]/div[1]/div/div[11]/button", "", 15);
            botaoEntrar.element.Click();

            Thread.Sleep(4000);

            var abas = driver.WindowHandles;

            if (abas.Count > 1)
            {
                driver.SwitchTo().Window(abas[abas.Count - 1]);
                driver.Close();
                driver.SwitchTo().Window(abas[0]);
                driver.Navigate().GoToUrl("https://s301-en.ikariam.gameforge.com/?view=city&cityId=384783");
            }
            Thread.Sleep(2000);

            var entrarNaIlha = AssignValue(TypeElement.Xpath, "//*[@id=\"js_islandLink\"]/a", "", 15);
            entrarNaIlha.element.Click();
            Thread.Sleep(2000);

            ////////////////////OBTER CORDENADA//////////////
            var inputCodX = AssignValue(TypeElement.Xpath, "//*[@id=\"inputXCoord\"]", "", 15);
            inputCodX.element.Clear();
            inputCodX.element.SendKeys(coordenadaX.ToString());
            Thread.Sleep(2000);

            var inputCodY = AssignValue(TypeElement.Xpath, "//*[@id=\"inputYCoord\"]", "", 15);
            inputCodY.element.Clear();
            inputCodY.element.SendKeys(coordenadaY.ToString());
            Thread.Sleep(2000);

            var EntrarNaCodernada = AssignValue(TypeElement.Xpath, "//*[@id=\"mapCoordInput\"]/form/input[3]", "", 15);
            EntrarNaCodernada.element.Click();
            Thread.Sleep(3000);
            ////////////////////FIM CORDENADA//////////////

            var selecionarAlvo = AssignValue(TypeElement.Xpath, xpath, "", 15);
            selecionarAlvo.element.Click();
            Thread.Sleep(2000);

            var iniciarRoubo = AssignValue(TypeElement.Xpath, "//*[@id=\"js_selectedCityAction2Link\"]", "", 15);
            iniciarRoubo.element.Click();
            Thread.Sleep(2000);


            /////////////////// SELECIONA A QUANTIDADE DE TROPA//////////////////
            var selecionarCatapulta = AssignValue(TypeElement.Xpath, "//*[@id=\"cargo_army_305\"]", quantidadeCatapulta.ToString(), 15);
            selecionarCatapulta.element.Click();
            Thread.Sleep(2000);


            var selecionarHoplita = AssignValue(TypeElement.Xpath, "//*[@id=\"cargo_army_303\"]", "", 15);
            selecionarHoplita.element.Click();
            Thread.Sleep(2000);
            /////////////////// SELECIONA A QUANTIDADE DE TROPA//////////////////
            

            var selecionarBarcos = AssignValue(TypeElement.Xpath, "//*[@id=\"extraTransporter\"]", "999", 15);
            selecionarBarcos.element.Click();
            Thread.Sleep(2000);

            var Roubar = AssignValue(TypeElement.Xpath, "//*[@id=\"plunderbutton\"]", "", 15);
            Roubar.element.Click();
            Thread.Sleep(2000);
            CloseBrowser();
        }
    }
}