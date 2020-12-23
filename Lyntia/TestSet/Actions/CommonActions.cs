﻿using System;
using System.Threading;
using Lyntia.TestSet.Conditions;
using Lyntia.Utilities;
using OpenQA.Selenium;

namespace Lyntia.TestSet.Actions
{
	public class CommonActions
	{

        private static IWebDriver driver = Utils.getDriver();
        private static OfertaActions ofertaActions = Utils.getOfertaActions();
        private static OfertaConditions ofertaCondition = Utils.getOfertaConditions();
        private static ProductoActions productoActions = Utils.getProductoActions();
        private static ProductoConditions productoCondition = Utils.getProductoConditions();
        private static CommonActions commonActions = Utils.getCommonActions();
        private static CommonConditions commonCondition = Utils.getCommonConditions();

        public void AccesoGestionCliente()
        {
            // Acceso al modulo Gestion del cliente
            Thread.Sleep(10000);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage"))); // Cambiar al frame de Apps
            driver.FindElement(By.XPath("//a[contains(@aria-label, 'Cliente')]")).Click(); //modulo gestion de clientes
        }

        public void AccesoOferta()
        {
            // Click en Ofertas, barra izquierda del CRM
            driver.FindElement(By.XPath("//li[@title='Ofertas']")).Click();
            Thread.Sleep(10000);

        }

        public int NumeroRegistrosEnGrid(By by)
        {
            return Int16.Parse(driver.FindElement(by).GetAttribute("data-row-count"));

        }

        public void Login()
        {
            // Login (acceso a PRE lyntia) 365 dinamic
            driver.FindElement(By.Id("i0116")).SendKeys("rgomezs.ext@lyntia.com"); //usuario de lyntia
            driver.FindElement(By.Id("idSIButton9")).Click();
            driver.FindElement(By.Id("userNameInput")).Clear();
            driver.FindElement(By.Id("userNameInput")).SendKeys("rgomezs@lyntia.com"); //usuario de entorno lyntia
            driver.FindElement(By.Id("passwordInput")).SendKeys("W1nter20$"); //pass de entorno lyntia
            driver.FindElement(By.Id("submitButton")).Click();
            driver.FindElement(By.Id("idBtn_Back")).Click(); //Desea mantener la sesion iniciada NO

        }
    }
}