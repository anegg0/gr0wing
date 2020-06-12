using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Localhost.Data;

namespace Localhost
{
    public partial class GrowingService
    {
        private readonly GrowingContext context;
        private readonly NavigationManager navigationManager;

        public GrowingService(GrowingContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportTblCustomersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblcustomers/excel") : "export/growing/tblcustomers/excel", true);
        }

        public async Task ExportTblCustomersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblcustomers/csv") : "export/growing/tblcustomers/csv", true);
        }

        partial void OnTblCustomersRead(ref IQueryable<Models.Growing.TblCustomer> items);

        public async Task<IQueryable<Models.Growing.TblCustomer>> GetTblCustomers(Query query = null)
        {
            var items = context.TblCustomers.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblCustomersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblCustomerCreated(Models.Growing.TblCustomer item);

        public async Task<Models.Growing.TblCustomer> CreateTblCustomer(Models.Growing.TblCustomer tblCustomer)
        {
            OnTblCustomerCreated(tblCustomer);

            context.TblCustomers.Add(tblCustomer);
            context.SaveChanges();

            return tblCustomer;
        }
        public async Task ExportTblOrdersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblorders/excel") : "export/growing/tblorders/excel", true);
        }

        public async Task ExportTblOrdersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblorders/csv") : "export/growing/tblorders/csv", true);
        }

        partial void OnTblOrdersRead(ref IQueryable<Models.Growing.TblOrder> items);

        public async Task<IQueryable<Models.Growing.TblOrder>> GetTblOrders(Query query = null)
        {
            var items = context.TblOrders.AsQueryable();

            items = items.Include(i => i.TblCustomer);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblOrdersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblOrderCreated(Models.Growing.TblOrder item);

        public async Task<Models.Growing.TblOrder> CreateTblOrder(Models.Growing.TblOrder tblOrder)
        {
            OnTblOrderCreated(tblOrder);

            context.TblOrders.Add(tblOrder);
            context.SaveChanges();

            return tblOrder;
        }
        public async Task ExportTblSeasonsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblseasons/excel") : "export/growing/tblseasons/excel", true);
        }

        public async Task ExportTblSeasonsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblseasons/csv") : "export/growing/tblseasons/csv", true);
        }

        partial void OnTblSeasonsRead(ref IQueryable<Models.Growing.TblSeason> items);

        public async Task<IQueryable<Models.Growing.TblSeason>> GetTblSeasons(Query query = null)
        {
            var items = context.TblSeasons.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSeasonsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSeasonCreated(Models.Growing.TblSeason item);

        public async Task<Models.Growing.TblSeason> CreateTblSeason(Models.Growing.TblSeason tblSeason)
        {
            OnTblSeasonCreated(tblSeason);

            context.TblSeasons.Add(tblSeason);
            context.SaveChanges();

            return tblSeason;
        }
        public async Task ExportTblSeedsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblseeds/excel") : "export/growing/tblseeds/excel", true);
        }

        public async Task ExportTblSeedsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblseeds/csv") : "export/growing/tblseeds/csv", true);
        }

        partial void OnTblSeedsRead(ref IQueryable<Models.Growing.TblSeed> items);

        public async Task<IQueryable<Models.Growing.TblSeed>> GetTblSeeds(Query query = null)
        {
            var items = context.TblSeeds.AsQueryable();

            items = items.Include(i => i.TblSeason);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSeedsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSeedCreated(Models.Growing.TblSeed item);

        public async Task<Models.Growing.TblSeed> CreateTblSeed(Models.Growing.TblSeed tblSeed)
        {
            OnTblSeedCreated(tblSeed);

            context.TblSeeds.Add(tblSeed);
            context.SaveChanges();

            return tblSeed;
        }
        public async Task ExportTblSuppliersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblsuppliers/excel") : "export/growing/tblsuppliers/excel", true);
        }

        public async Task ExportTblSuppliersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tblsuppliers/csv") : "export/growing/tblsuppliers/csv", true);
        }

        partial void OnTblSuppliersRead(ref IQueryable<Models.Growing.TblSupplier> items);

        public async Task<IQueryable<Models.Growing.TblSupplier>> GetTblSuppliers(Query query = null)
        {
            var items = context.TblSuppliers.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSuppliersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSupplierCreated(Models.Growing.TblSupplier item);

        public async Task<Models.Growing.TblSupplier> CreateTblSupplier(Models.Growing.TblSupplier tblSupplier)
        {
            OnTblSupplierCreated(tblSupplier);

            context.TblSuppliers.Add(tblSupplier);
            context.SaveChanges();

            return tblSupplier;
        }
        public async Task ExportTblTraysToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tbltrays/excel") : "export/growing/tbltrays/excel", true);
        }

        public async Task ExportTblTraysToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tbltrays/csv") : "export/growing/tbltrays/csv", true);
        }

        partial void OnTblTraysRead(ref IQueryable<Models.Growing.TblTray> items);

        public async Task<IQueryable<Models.Growing.TblTray>> GetTblTrays(Query query = null)
        {
            var items = context.TblTrays.AsQueryable();

            items = items.Include(i => i.TblTrayType);

            items = items.Include(i => i.TblSeed);

            items = items.Include(i => i.TblCustomer);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblTraysRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblTrayCreated(Models.Growing.TblTray item);

        public async Task<Models.Growing.TblTray> CreateTblTray(Models.Growing.TblTray tblTray)
        {
            OnTblTrayCreated(tblTray);

            context.TblTrays.Add(tblTray);
            context.SaveChanges();

            return tblTray;
        }
        public async Task ExportTblTrayTypesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tbltraytypes/excel") : "export/growing/tbltraytypes/excel", true);
        }

        public async Task ExportTblTrayTypesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/growing/tbltraytypes/csv") : "export/growing/tbltraytypes/csv", true);
        }

        partial void OnTblTrayTypesRead(ref IQueryable<Models.Growing.TblTrayType> items);

        public async Task<IQueryable<Models.Growing.TblTrayType>> GetTblTrayTypes(Query query = null)
        {
            var items = context.TblTrayTypes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblTrayTypesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblTrayTypeCreated(Models.Growing.TblTrayType item);

        public async Task<Models.Growing.TblTrayType> CreateTblTrayType(Models.Growing.TblTrayType tblTrayType)
        {
            OnTblTrayTypeCreated(tblTrayType);

            context.TblTrayTypes.Add(tblTrayType);
            context.SaveChanges();

            return tblTrayType;
        }

        partial void OnTblCustomerDeleted(Models.Growing.TblCustomer item);

        public async Task<Models.Growing.TblCustomer> DeleteTblCustomer(int? customerId)
        {
            var item = context.TblCustomers
                              .Where(i => i.CustomerId == customerId)
                              .Include(i => i.TblOrders)
                              .Include(i => i.TblTrays)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblCustomerDeleted(item);

            context.TblCustomers.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblCustomerGet(Models.Growing.TblCustomer item);

        public async Task<Models.Growing.TblCustomer> GetTblCustomerByCustomerId(int? customerId)
        {
            var items = context.TblCustomers
                              .AsNoTracking()
                              .Where(i => i.CustomerId == customerId);

            var item = items.FirstOrDefault();

            OnTblCustomerGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblCustomer> CancelTblCustomerChanges(Models.Growing.TblCustomer item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblCustomerUpdated(Models.Growing.TblCustomer item);

        public async Task<Models.Growing.TblCustomer> UpdateTblCustomer(int? customerId, Models.Growing.TblCustomer tblCustomer)
        {
            OnTblCustomerUpdated(tblCustomer);

            var item = context.TblCustomers
                              .Where(i => i.CustomerId == customerId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblCustomer);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblCustomer;
        }

        partial void OnTblOrderDeleted(Models.Growing.TblOrder item);

        public async Task<Models.Growing.TblOrder> DeleteTblOrder(int? orderId)
        {
            var item = context.TblOrders
                              .Where(i => i.OrderId == orderId)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblOrderDeleted(item);

            context.TblOrders.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblOrderGet(Models.Growing.TblOrder item);

        public async Task<Models.Growing.TblOrder> GetTblOrderByOrderId(int? orderId)
        {
            var items = context.TblOrders
                              .AsNoTracking()
                              .Where(i => i.OrderId == orderId);

            items = items.Include(i => i.TblCustomer);

            var item = items.FirstOrDefault();

            OnTblOrderGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblOrder> CancelTblOrderChanges(Models.Growing.TblOrder item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblOrderUpdated(Models.Growing.TblOrder item);

        public async Task<Models.Growing.TblOrder> UpdateTblOrder(int? orderId, Models.Growing.TblOrder tblOrder)
        {
            OnTblOrderUpdated(tblOrder);

            var item = context.TblOrders
                              .Where(i => i.OrderId == orderId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblOrder);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblOrder;
        }

        partial void OnTblSeasonDeleted(Models.Growing.TblSeason item);

        public async Task<Models.Growing.TblSeason> DeleteTblSeason(int? seasonId)
        {
            var item = context.TblSeasons
                              .Where(i => i.SeasonId == seasonId)
                              .Include(i => i.TblSeeds)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSeasonDeleted(item);

            context.TblSeasons.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblSeasonGet(Models.Growing.TblSeason item);

        public async Task<Models.Growing.TblSeason> GetTblSeasonBySeasonId(int? seasonId)
        {
            var items = context.TblSeasons
                              .AsNoTracking()
                              .Where(i => i.SeasonId == seasonId);

            var item = items.FirstOrDefault();

            OnTblSeasonGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblSeason> CancelTblSeasonChanges(Models.Growing.TblSeason item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSeasonUpdated(Models.Growing.TblSeason item);

        public async Task<Models.Growing.TblSeason> UpdateTblSeason(int? seasonId, Models.Growing.TblSeason tblSeason)
        {
            OnTblSeasonUpdated(tblSeason);

            var item = context.TblSeasons
                              .Where(i => i.SeasonId == seasonId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSeason);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSeason;
        }

        partial void OnTblSeedDeleted(Models.Growing.TblSeed item);

        public async Task<Models.Growing.TblSeed> DeleteTblSeed(int? seedId)
        {
            var item = context.TblSeeds
                              .Where(i => i.SeedId == seedId)
                              .Include(i => i.TblTrays)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSeedDeleted(item);

            context.TblSeeds.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblSeedGet(Models.Growing.TblSeed item);

        public async Task<Models.Growing.TblSeed> GetTblSeedBySeedId(int? seedId)
        {
            var items = context.TblSeeds
                              .AsNoTracking()
                              .Where(i => i.SeedId == seedId);

            items = items.Include(i => i.TblSeason);

            var item = items.FirstOrDefault();

            OnTblSeedGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblSeed> CancelTblSeedChanges(Models.Growing.TblSeed item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSeedUpdated(Models.Growing.TblSeed item);

        public async Task<Models.Growing.TblSeed> UpdateTblSeed(int? seedId, Models.Growing.TblSeed tblSeed)
        {
            OnTblSeedUpdated(tblSeed);

            var item = context.TblSeeds
                              .Where(i => i.SeedId == seedId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSeed);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSeed;
        }

        partial void OnTblSupplierDeleted(Models.Growing.TblSupplier item);

        public async Task<Models.Growing.TblSupplier> DeleteTblSupplier(int? supplierId)
        {
            var item = context.TblSuppliers
                              .Where(i => i.SupplierId == supplierId)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblSupplierDeleted(item);

            context.TblSuppliers.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblSupplierGet(Models.Growing.TblSupplier item);

        public async Task<Models.Growing.TblSupplier> GetTblSupplierBySupplierId(int? supplierId)
        {
            var items = context.TblSuppliers
                              .AsNoTracking()
                              .Where(i => i.SupplierId == supplierId);

            var item = items.FirstOrDefault();

            OnTblSupplierGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblSupplier> CancelTblSupplierChanges(Models.Growing.TblSupplier item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSupplierUpdated(Models.Growing.TblSupplier item);

        public async Task<Models.Growing.TblSupplier> UpdateTblSupplier(int? supplierId, Models.Growing.TblSupplier tblSupplier)
        {
            OnTblSupplierUpdated(tblSupplier);

            var item = context.TblSuppliers
                              .Where(i => i.SupplierId == supplierId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSupplier);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSupplier;
        }

        partial void OnTblTrayDeleted(Models.Growing.TblTray item);

        public async Task<Models.Growing.TblTray> DeleteTblTray(int? trayId)
        {
            var item = context.TblTrays
                              .Where(i => i.TrayId == trayId)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblTrayDeleted(item);

            context.TblTrays.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblTrayGet(Models.Growing.TblTray item);

        public async Task<Models.Growing.TblTray> GetTblTrayByTrayId(int? trayId)
        {
            var items = context.TblTrays
                              .AsNoTracking()
                              .Where(i => i.TrayId == trayId);

            items = items.Include(i => i.TblTrayType);

            items = items.Include(i => i.TblSeed);

            items = items.Include(i => i.TblCustomer);

            var item = items.FirstOrDefault();

            OnTblTrayGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblTray> CancelTblTrayChanges(Models.Growing.TblTray item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblTrayUpdated(Models.Growing.TblTray item);

        public async Task<Models.Growing.TblTray> UpdateTblTray(int? trayId, Models.Growing.TblTray tblTray)
        {
            OnTblTrayUpdated(tblTray);

            var item = context.TblTrays
                              .Where(i => i.TrayId == trayId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblTray);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblTray;
        }

        partial void OnTblTrayTypeDeleted(Models.Growing.TblTrayType item);

        public async Task<Models.Growing.TblTrayType> DeleteTblTrayType(int? trayTypeId)
        {
            var item = context.TblTrayTypes
                              .Where(i => i.TrayTypeId == trayTypeId)
                              .Include(i => i.TblTrays)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnTblTrayTypeDeleted(item);

            context.TblTrayTypes.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnTblTrayTypeGet(Models.Growing.TblTrayType item);

        public async Task<Models.Growing.TblTrayType> GetTblTrayTypeByTrayTypeId(int? trayTypeId)
        {
            var items = context.TblTrayTypes
                              .AsNoTracking()
                              .Where(i => i.TrayTypeId == trayTypeId);

            var item = items.FirstOrDefault();

            OnTblTrayTypeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.Growing.TblTrayType> CancelTblTrayTypeChanges(Models.Growing.TblTrayType item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblTrayTypeUpdated(Models.Growing.TblTrayType item);

        public async Task<Models.Growing.TblTrayType> UpdateTblTrayType(int? trayTypeId, Models.Growing.TblTrayType tblTrayType)
        {
            OnTblTrayTypeUpdated(tblTrayType);

            var item = context.TblTrayTypes
                              .Where(i => i.TrayTypeId == trayTypeId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblTrayType);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblTrayType;
        }
    }
}
