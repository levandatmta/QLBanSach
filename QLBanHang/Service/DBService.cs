﻿using QLBanHang.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.Service
{
    public static class DBService
    {
        public static QLBanSACH_DbContext db = new QLBanSACH_DbContext();

        public static void Reload()
        {
            try
            {
                var context = ((IObjectContextAdapter)db).ObjectContext;
                var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                           EntityState.Added
                                                           | EntityState.Deleted
                                                           | EntityState.Modified
                                                           | EntityState.Unchanged)
                                          where entry.EntityKey != null
                                          select entry.Entity).ToList();

                context.Refresh(RefreshMode.StoreWins, refreshableObjects);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
    }
}
