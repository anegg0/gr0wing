using Microsoft.AspNetCore.Mvc;
using Growing.Data;

namespace Growing
{
    public partial class ExportGrowingController : ExportController
    {
        private readonly GrowingContext context;

        public ExportGrowingController(GrowingContext context)
        {
            this.context = context;
        }

        [HttpGet("/export/Growing/tblcustomers/csv")]
        public FileStreamResult ExportTblCustomersToCSV()
        {
            return ToCSV(ApplyQuery(context.TblCustomers, Request.Query));
        }

        [HttpGet("/export/Growing/tblcustomers/excel")]
        public FileStreamResult ExportTblCustomersToExcel()
        {
            return ToExcel(ApplyQuery(context.TblCustomers, Request.Query));
        }

        [HttpGet("/export/Growing/tblorders/csv")]
        public FileStreamResult ExportTblOrdersToCSV()
        {
            return ToCSV(ApplyQuery(context.TblOrders, Request.Query));
        }

        [HttpGet("/export/Growing/tblorders/excel")]
        public FileStreamResult ExportTblOrdersToExcel()
        {
            return ToExcel(ApplyQuery(context.TblOrders, Request.Query));
        }

        [HttpGet("/export/Growing/tblseasons/csv")]
        public FileStreamResult ExportTblSeasonsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblSeasons, Request.Query));
        }

        [HttpGet("/export/Growing/tblseasons/excel")]
        public FileStreamResult ExportTblSeasonsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblSeasons, Request.Query));
        }

        [HttpGet("/export/Growing/tblseeds/csv")]
        public FileStreamResult ExportTblSeedsToCSV()
        {
            return ToCSV(ApplyQuery(context.TblSeeds, Request.Query));
        }

        [HttpGet("/export/Growing/tblseeds/excel")]
        public FileStreamResult ExportTblSeedsToExcel()
        {
            return ToExcel(ApplyQuery(context.TblSeeds, Request.Query));
        }

        [HttpGet("/export/Growing/tblsuppliers/csv")]
        public FileStreamResult ExportTblSuppliersToCSV()
        {
            return ToCSV(ApplyQuery(context.TblSuppliers, Request.Query));
        }

        [HttpGet("/export/Growing/tblsuppliers/excel")]
        public FileStreamResult ExportTblSuppliersToExcel()
        {
            return ToExcel(ApplyQuery(context.TblSuppliers, Request.Query));
        }

        [HttpGet("/export/Growing/tbltrays/csv")]
        public FileStreamResult ExportTblTraysToCSV()
        {
            return ToCSV(ApplyQuery(context.TblTrays, Request.Query));
        }

        [HttpGet("/export/Growing/tbltrays/excel")]
        public FileStreamResult ExportTblTraysToExcel()
        {
            return ToExcel(ApplyQuery(context.TblTrays, Request.Query));
        }

        [HttpGet("/export/Growing/tbltraytypes/csv")]
        public FileStreamResult ExportTblTrayTypesToCSV()
        {
            return ToCSV(ApplyQuery(context.TblTrayTypes, Request.Query));
        }

        [HttpGet("/export/Growing/tbltraytypes/excel")]
        public FileStreamResult ExportTblTrayTypesToExcel()
        {
            return ToExcel(ApplyQuery(context.TblTrayTypes, Request.Query));
        }
    }
}
