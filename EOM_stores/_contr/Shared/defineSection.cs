using System.Windows.Forms;
using System.Drawing;
using System;

namespace EOM_stores._contr.Shared
{
    class defineSection
    {
        public string _section;
        
        
        public string section { get; set; }

       
        private void prepareSecction()
        {
            _section = section;
        }

        public void reDataPrd()
        {
            Ul.Shared.eeProduct EEP = new Ul.Shared.eeProduct();
            EEP.TopMost = true;
            EEP.Show();
            EEP.Location = new Point(20, 51);
            products._prdc pr = new products._prdc();
            EEP.dgvEE.DataSource = pr.displayProducts();
            EEP.txtCost.Text =EEP.dgvEE.CurrentRow.Cells[13].Value.ToString();
            EEP.TopMost = true;
        }


        public void reDataCust()
        {
            Ul.Manages.eeCustomers EEC = new Ul.Manages.eeCustomers();
            EEC.TopMost = true;
            EEC.Show();
            EEC.Location = new Point(20, 51);
            _custCtrl ctl = new _custCtrl();
            EEC.dgvEECustomer.DataSource = ctl.getA_Customers();
        }

        
        public void getSection(string _section)
        {
           
            if (_section=="addProduct")
            {
               
                Ul.Shared.product prd = new Ul.Shared.product();
                prd.TopMost = true;
                prd.Show();
                //bringThisToFront(prd);

                prd.Location = new Point(20, 51);
                prd.formSection = "addProduct";
                
            }

            else if (_section=="manageProduct")
            {
                reDataPrd();
            }

            else if (_section=="addCustomer")
            {
                Ul.customers.ACus acs = new Ul.customers.ACus();
                acs.TopMost = true;
                acs.Show();
                //bringThisToFront(acs);
                acs.Location = new Point(20, 51);
            }

            else if (_section == "productCost")
            {
                Ul.Operations.costingPreview costing= new Ul.Operations.costingPreview();
                costing.TopMost = true;
                costing.Show();
                //bringThisToFront(acs);
                costing.Location = new Point(20, 51);
            }

            else if (_section=="manageCustomers")
            {
                reDataCust();
                
            }

            else if(_section=="addImporters")
            {
                
                Ul.Imports.AImp aimp = new Ul.Imports.AImp();
                aimp.TopMost = true;
                aimp.Show();
                //bringThisToFront(aimp);
                aimp.Location = new Point(20, 51);

            }

            else if(_section=="manageImporters")
            {
                Ul.Manages.eeImporters eei = new Ul.Manages.eeImporters();
                eei.TopMost = true;
                eei.Show();
                //bringThisToFront(eei);
                eei.Location = new Point(20, 51);
            }

            else if (_section == "addEmployee")
            {
                Ul.Employees.AdEmployee ademp = new Ul.Employees.AdEmployee();
                ademp.TopMost = true;
                ademp.Show();
                //bringThisToFront(ademp);
                ademp.Location = new Point(20, 51);
            }

            else if (_section == "manageEmployees")
            {

            }

            else if (_section == "addWorker")
            {
                Ul.Worksh.adWorker adWorker = new Ul.Worksh.adWorker();
                adWorker.TopMost = true;
                adWorker.Show();
                //bringThisToFront(adWorker);
                adWorker.Location = new Point(20, 51);
            }

            else if (_section == "manageWorkers")
            {
                Ul.Manages.eeWorkers eew = new Ul.Manages.eeWorkers();
                eew.TopMost = true;
                eew.Show();
                //bringThisToFront(eew);
                eew.Location = new Point(20, 51);
            }

            else if (_section == "workersCheck")
            {

                Ul.Manages.workerCheck eewc = new Ul.Manages.workerCheck();
                eewc.TopMost = true;
                eewc.Show();
                //bringThisToFront(eewc);
                eewc.Location = new Point(20, 51);
                
            }

            else if (_section == "addCategory")
            {
                Ul.Categories.aCat ac = new Ul.Categories.aCat();
                ac.TopMost = true;
                ac.Show();
                //bringThisToFront(ac);
                ac.Location = new Point(20, 51);
            }

            

            else if (_section == "empSalary")
            {
                Ul.Accounts.worker_salaries emsalary = new Ul.Accounts.worker_salaries();
                emsalary.TopMost = true;
                emsalary.Show();
                //bringThisToFront(emsalary);
                emsalary.Location = new Point(20, 51);
            }

            else if (_section == "worSalary")
            {
                Ul.Accounts.worker_salaries sa = new Ul.Accounts.worker_salaries();
                sa.TopMost = true;
                sa.Show();
                sa.Location = new Point(20, 51);
                //bringThisToFront(sa);
               
            }

            else if (_section == "addUser")
            {
                Ul.__.AddUsrs adus = new Ul.__.AddUsrs();
                adus.TopMost = true;
                adus.Show();
                //bringThisToFront(adus);
                adus.Location = new Point(20, 51);
            }

            else if (_section == "manageUsers")
            {

            }

            else if (_section == "reciveOrder")
            {
                
                Ul.Operations.recive_order rvo = new Ul.Operations.recive_order();
                rvo.TopMost = true;
                rvo.Show();
                //bringThisToFront(rvo);
                rvo.Location = new Point(20, 51);
            }

            else if (_section == "saleOrder")
            {
                
                Ul.Operations.sale_order so = new Ul.Operations.sale_order();
                so.TopMost = true;
                so.Show();
                //bringThisToFront(so);
                so.Location = new Point(20, 51);
                
            }

            else if (_section == "manageOrders")
            {
                
                Ul.Operations.eeOrder eeOrder = new Ul.Operations.eeOrder();
                eeOrder.TopMost = true;
                eeOrder.Show();
                //bringThisToFront(eeOrder);
                eeOrder.Location = new Point(20, 51);

            }

            else if (_section == "manageReciveOrders")
            {
                
                Ul.Operations.eeReciveOrder eeRcieOrder = new Ul.Operations.eeReciveOrder();
                eeRcieOrder.TopMost = true;
                eeRcieOrder.Show();
                //bringThisToFront(eeRcieOrder);
                eeRcieOrder.Location = new Point(20, 51);

            }
            else if (_section=="balanceSheet")
            {
                Ul.Manages.balance_sheet bs = new Ul.Manages.balance_sheet();
                bs.TopMost = true;
                bs.Show();
                //bringThisToFront(bs);
                bs.Location = new Point(20, 51);
            }

            else if (_section == "inOutAccounts")
            {
                Ul.Accounts.inAccount insAccount = new Ul.Accounts.inAccount();
                insAccount.TopMost = true;
                insAccount.Show();
                //bringThisToFront(insAccount);
                insAccount.Location = new Point(20, 51);
            }

            else if (_section == "prevAccounts")
            {
                Ul.Manages.eeAccount eeAccount = new Ul.Manages.eeAccount();
                eeAccount.TopMost = true;
                eeAccount.Show();
                //bringThisToFront(eeAccount);
                eeAccount.Location = new Point(20, 51);
            }

            else if (_section == "changeHash")
            {
                Ul.__.changePasswd chPaswd= new Ul.__.changePasswd();
                chPaswd.TopMost = true;
                chPaswd.Show();
                //bringThisToFront(eeAccount);
                chPaswd.Location = new Point(20, 51);
            }
        }

    }
}
