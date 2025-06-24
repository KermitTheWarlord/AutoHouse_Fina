using AutoHouse.Core;
using AutoHouse.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoHouse.ConsoleApp
{
    public class Display
    {
        private readonly CarController carController;
        private readonly CustomerController customerController;
        private readonly EmployeeController employeeController;
        private readonly ServiceController serviceController;
        private readonly SaleController saleController;
        private readonly CarServiceController carServiceController;
        private readonly EmployeeServiceController employeeServiceController;

        public Display(
            CarController carCtrl,
            CustomerController custCtrl,
            EmployeeController empCtrl,
            ServiceController svcCtrl,
            SaleController saleCtrl,
            CarServiceController carSvcCtrl,
            EmployeeServiceController empSvcCtrl)
        {
            carController = carCtrl;
            customerController = custCtrl;
            employeeController = empCtrl;
            serviceController = svcCtrl;
            saleController = saleCtrl;
            carServiceController = carSvcCtrl;
            employeeServiceController = empSvcCtrl;
        }

        public async Task ControllerConfiguration()
        {
            await carController.CarConfigurations();
            await customerController.CustomerConfigurations();
            await employeeController.EmployeeConfigurations();
            await serviceController.ServiceConfigurations();
            await saleController.SaleConfigurations();
            await carServiceController.CarServiceConfigurations();
            await employeeServiceController.EmployeeServiceConfigurations();
        }

        public async Task ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("===== AutoHouse Menu =====");
                Console.WriteLine("1.  Add new car");
                Console.WriteLine("2.  View car by ID");
                Console.WriteLine("3.  Update car price");
                Console.WriteLine("4.  Delete car");
                Console.WriteLine("5.  Search cars by make");
                Console.WriteLine("6.  List cars by service ID");
                Console.WriteLine();
                Console.WriteLine("7.  Add new customer");
                Console.WriteLine("8.  View customer by ID");
                Console.WriteLine("9.  Update customer");
                Console.WriteLine("10. Delete customer");
                Console.WriteLine("11. Search customers by last name");
                Console.WriteLine("12. Search customers by email domain");
                Console.WriteLine();
                Console.WriteLine("13. Add new employee");
                Console.WriteLine("14. View employee by ID");
                Console.WriteLine("15. Update employee");
                Console.WriteLine("16. Delete employee");
                Console.WriteLine("17. Search employees by service ID");
                Console.WriteLine("18. Search employees by position");
                Console.WriteLine();
                Console.WriteLine("19. Add new sale");
                Console.WriteLine("20. View sale by ID");
                Console.WriteLine("21. Delete sale");
                Console.WriteLine("22. List sales by date range");
                Console.WriteLine("23. Sales count report by customer");
                Console.WriteLine("24. List sales for customer ID");
                Console.WriteLine();
                Console.WriteLine("25. List services used by customer ID");
                Console.WriteLine("26. List services for car ID");
                Console.WriteLine("27. List services by employee ID");
                Console.WriteLine("28. Top N most-used services");
                Console.WriteLine("29. Cars within price range");
                Console.WriteLine("0.  Exit");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "0": return;
                    case "1": await AddCarMenu(); break;
                    case "2": await ViewCarMenu(); break;
                    case "3": await UpdateCarMenu(); break;
                    case "4": await DeleteCarMenu(); break;
                    case "5": await SearchCarsByMakeMenu(); break;
                    case "6": await ListCarsByServiceMenu(); break;

                    case "7": await AddCustomerMenu(); break;
                    case "8": await ViewCustomerMenu(); break;
                    case "9": await UpdateCustomerMenu(); break;
                    case "10": await DeleteCustomerMenu(); break;
                    case "11": await SearchCustomersByLastNameMenu(); break;
                    case "12": await SearchCustomersByEmailDomainMenu(); break;

                    case "13": await AddEmployeeMenu(); break;
                    case "14": await ViewEmployeeMenu(); break;
                    case "15": await UpdateEmployeeMenu(); break;
                    case "16": await DeleteEmployeeMenu(); break;
                    case "17": await SearchEmployeesByServiceMenu(); break;
                    case "18": await SearchEmployeesByPositionMenu(); break;

                    case "19": await AddSaleMenu(); break;
                    case "20": await ViewSaleMenu(); break;
                    case "21": await DeleteSaleMenu(); break;
                    case "22": await ListSalesByDateRangeMenu(); break;
                    case "23": await SalesCountByCustomerMenu(); break;
                    case "24": await ListSalesByCustomerMenu(); break;

                    case "25": await ListServicesByCustomerMenu(); break;
                    case "26": await ListServicesByCarMenu(); break;
                    case "27": await ListServicesByEmployeeMenu(); break;
                    case "28": await TopServicesMenu(); break;
                    case "29": await CarsByPriceRangeMenu(); break;

                    default: Console.WriteLine("Invalid choice\n"); break;
                }
            }
        }

        private async Task AddCarMenu()
        {
            Console.Write("Make: "); var make = Console.ReadLine();
            Console.Write("Model: "); var model = Console.ReadLine();
            Console.Write("Year: "); var year = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Price: "); var price = decimal.Parse(Console.ReadLine() ?? "0");
            var car = await carController.AddCar(make, model, year, price);
            Console.WriteLine($"Added Car ID: {car.Id}\n");
        }

        private async Task ViewCarMenu()
        {
            Console.Write("Car ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            var car = await carController.GetCarById(id);
            Console.WriteLine(car != null
                ? $"{car.Id}: {car.Make} {car.Model}, {car.Year}, {car.Price}\n"
                : "Car not found\n");
        }

        private async Task UpdateCarMenu()
        {
            Console.Write("Car ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("New Price: "); var price = decimal.Parse(Console.ReadLine() ?? "0");
            var car = await carController.UpdateCarPrice(id, price);
            Console.WriteLine(car != null
                ? $"Updated Car: {car.Id} now costs {car.Price}\n"
                : "Car not found\n");
        }

        private async Task DeleteCarMenu()
        {
            Console.Write("Car ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            bool ok = await carController.DeleteCar(id);
            Console.WriteLine(ok ? "Car deleted\n" : "Car not found\n");
        }

        private async Task SearchCarsByMakeMenu()
        {
            Console.Write("Make: "); var make = Console.ReadLine();
            var list = await carController.GetCarsByMake(make);
            Console.WriteLine("Cars:");
            list.ForEach(c => Console.WriteLine($"{c.Id}: {c.Make} {c.Model}, {c.Year}, {c.Price}"));
            Console.WriteLine();
        }

        private async Task ListCarsByServiceMenu()
        {
            Console.Write("Service ID: "); var sid = int.Parse(Console.ReadLine() ?? "0");
            var cars = await serviceController.GetCarsByService(sid);
            Console.WriteLine("Cars with Service:");
            cars.ForEach(c => Console.WriteLine($"{c.Id}: {c.Make} {c.Model}, {c.Price}"));
            Console.WriteLine();
        }

        // ... Similar implementation for Customers ...
        private async Task AddCustomerMenu()
        {
            Console.Write("First Name: "); var fn = Console.ReadLine();
            Console.Write("Last Name: "); var ln = Console.ReadLine();
            Console.Write("Phone: "); var ph = Console.ReadLine();
            Console.Write("Email: "); var em = Console.ReadLine();
            var cust = await customerController.AddCustomer(fn, ln, ph, em);
            Console.WriteLine($"Added Customer ID: {cust.Id}\n");
        }

        private async Task ViewCustomerMenu()
        {
            Console.Write("Customer ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            var c = await customerController.GetCustomerById(id);
            Console.WriteLine(c != null
                ? $"{c.Id}: {c.FirstName} {c.LastName}, {c.PhoneNumber}, {c.Email}\n"
                : "Customer not found\n");
        }

        private async Task UpdateCustomerMenu()
        {
            Console.Write("Customer ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("New Phone: "); var ph = Console.ReadLine();
            Console.Write("New Email: "); var em = Console.ReadLine();
            var c = await customerController.UpdateCustomer(id, ph, em);
            Console.WriteLine(c != null ? "Customer updated\n" : "Customer not found\n");
        }

        private async Task DeleteCustomerMenu()
        {
            Console.Write("Customer ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            bool ok = await customerController.DeleteCustomer(id);
            Console.WriteLine(ok ? "Customer deleted\n" : "Customer not found\n");
        }

        private async Task SearchCustomersByLastNameMenu()
        {
            Console.Write("Last Name: "); var ln = Console.ReadLine();
            var list = await customerController.GetCustomersByLastName(ln);
            list.ForEach(c => Console.WriteLine($"{c.Id}: {c.FirstName} {c.LastName}"));
            Console.WriteLine();
        }

        private async Task SearchCustomersByEmailDomainMenu()
        {
            Console.Write("Email domain (e.g. example.com): "); var d = Console.ReadLine();
            var list = await customerController.GetCustomersByEmailDomain(d);
            list.ForEach(c => Console.WriteLine($"{c.Id}: {c.Email}"));
            Console.WriteLine();
        }

        // ... Employees ...
        private async Task AddEmployeeMenu()
        {
            Console.Write("First Name: "); var fn = Console.ReadLine();
            Console.Write("Last Name: "); var ln = Console.ReadLine();
            Console.Write("Position: "); var pos = Console.ReadLine();
            Console.Write("Phone: "); var ph = Console.ReadLine();
            Console.Write("Email: "); var em = Console.ReadLine();
            var emp = await employeeController.AddEmployee(fn, ln, pos, ph, em);
            Console.WriteLine($"Added Employee ID: {emp.Id}\n");
        }

        private async Task ViewEmployeeMenu()
        {
            Console.Write("Employee ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            var e = await employeeController.GetEmployeeById(id);
            Console.WriteLine(e != null
                ? $"{e.Id}: {e.FirstName} {e.LastName}, {e.Position}, {e.PhoneNumber}, {e.Email}\n"
                : "Employee not found\n");
        }

        private async Task UpdateEmployeeMenu()
        {
            Console.Write("Employee ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("New Position: "); var pos = Console.ReadLine();
            Console.Write("New Phone: "); var ph = Console.ReadLine();
            var e = await employeeController.UpdateEmployee(id, pos, ph);
            Console.WriteLine(e != null ? "Employee updated\n" : "Employee not found\n");
        }

        private async Task DeleteEmployeeMenu()
        {
            Console.Write("Employee ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            bool ok = await employeeController.DeleteEmployee(id);
            Console.WriteLine(ok ? "Employee deleted\n" : "Employee not found\n");
        }

        private async Task SearchEmployeesByServiceMenu()
        {
            Console.Write("Service ID: "); var sid = int.Parse(Console.ReadLine() ?? "0");
            var list = await employeeController.GetEmployeesByService(sid);
            list.ForEach(e => Console.WriteLine($"{e.Id}: {e.FirstName} {e.LastName}"));
            Console.WriteLine();
        }

        private async Task SearchEmployeesByPositionMenu()
        {
            Console.Write("Position: "); var pos = Console.ReadLine();
            var list = await employeeController.GetEmployeesByPosition(pos);
            list.ForEach(e => Console.WriteLine($"{e.Id}: {e.Position}"));
            Console.WriteLine();
        }

        // ... Sales ...
        private async Task AddSaleMenu()
        {
            Console.Write("Car ID: "); var cid = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Customer ID: "); var cuid = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Employee ID (or blank): "); var eidText = Console.ReadLine();
            int? eid = string.IsNullOrEmpty(eidText) ? null : int.Parse(eidText);
            Console.Write("Date (YYYY-MM-DD): "); var date = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());
            Console.Write("Price: "); var price = decimal.Parse(Console.ReadLine() ?? "0");
            var sale = await saleController.AddSale(cid, cuid, eid, date, price);
            Console.WriteLine($"Added Sale ID: {sale.Id}\n");
        }

        private async Task ViewSaleMenu()
        {
            Console.Write("Sale ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            var s = await saleController.GetSaleById(id);
            if (s != null)
            {
                Console.WriteLine($"{s.Id}: {s.Car.Make} {s.Car.Model} sold to {s.Customer.FirstName} on {s.Date:d}, Price {s.Price}\n");
            }
            else Console.WriteLine("Sale not found\n");
        }

        private async Task DeleteSaleMenu()
        {
            Console.Write("Sale ID: "); var id = int.Parse(Console.ReadLine() ?? "0");
            bool ok = await saleController.DeleteSale(id);
            Console.WriteLine(ok ? "Sale deleted\n" : "Sale not found\n");
        }

        private async Task ListSalesByDateRangeMenu()
        {
            Console.Write("Start Date (YYYY-MM-DD): "); var start = DateTime.Parse(Console.ReadLine());
            Console.Write("End Date   (YYYY-MM-DD): "); var end = DateTime.Parse(Console.ReadLine());
            var list = await saleController.GetSalesByDateRange(start, end);
            list.ForEach(s => Console.WriteLine($"{s.Id}: {s.Date:d} - {s.Car.Make} to {s.Customer.FirstName}"));
            Console.WriteLine();
        }

        private async Task SalesCountByCustomerMenu()
        {
            var dict = await saleController.GetSalesCountByCustomer();
            foreach (var kv in dict)
                Console.WriteLine($"{kv.Key}: {kv.Value} sales");
            Console.WriteLine();
        }

        private async Task ListSalesByCustomerMenu()
        {
            Console.Write("Customer ID: "); var cid = int.Parse(Console.ReadLine() ?? "0");
            var list = await saleController.GetSalesByCustomer(cid);
            list.ForEach(s => Console.WriteLine($"{s.Id}: {s.Car.Make} on {s.Date:d}"));
            Console.WriteLine();
        }

        private async Task ListServicesByCustomerMenu()
        {
            Console.Write("Customer ID: "); var cid = int.Parse(Console.ReadLine() ?? "0");
            var list = await serviceController.GetServicesByCustomer(cid);
            list.ForEach(s => Console.WriteLine($"{s.Id}: {s.Name}"));
            Console.WriteLine();
        }

        private async Task ListServicesByCarMenu()
        {
            Console.Write("Car ID: "); var cid = int.Parse(Console.ReadLine() ?? "0");
            var list = await serviceController.GetServicesByCar(cid);
            list.ForEach(s => Console.WriteLine($"{s.Id}: {s.Name}"));
            Console.WriteLine();
        }

        private async Task ListServicesByEmployeeMenu()
        {
            Console.Write("Employee ID: "); var eid = int.Parse(Console.ReadLine() ?? "0");
            var list = await serviceController.GetServicesByEmployee(eid);
            list.ForEach(s => Console.WriteLine($"{s.Id}: {s.Name}"));
            Console.WriteLine();
        }

        private async Task TopServicesMenu()
        {
            Console.Write("Top N: "); var n = int.Parse(Console.ReadLine() ?? "0");
            var list = await serviceController.GetTopServices(n);
            Console.WriteLine("Top services:");
            list.ForEach(name => Console.WriteLine($"- {name}"));
            Console.WriteLine();
        }

        private async Task CarsByPriceRangeMenu()
        {
            Console.Write("Min price: "); var min = decimal.Parse(Console.ReadLine() ?? "0");
            Console.Write("Max price: "); var max = decimal.Parse(Console.ReadLine() ?? "0");
            var list = await carController.GetCarsByPriceRange(min, max);
            list.ForEach(c => Console.WriteLine($"{c.Id}: {c.Make} {c.Model} - {c.Price}"));
            Console.WriteLine();
        }
    }
}
