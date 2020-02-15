﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.LayUIDemo.Models;


namespace WalkingTec.Mvvm.LayUIDemo.ViewModels.ContractorVMs
{
    public partial class ContractorVM : BaseCRUDVM<Contractor>
    {
        public List<ComboSelectListItem> AllProvinces { get; set; }

        public ContractorVM()
        {
            SetInclude(x => x.Province);
        }

        protected override void InitVM()
        {
            AllProvinces = DC.Set<Province>().GetSelectListItems(LoginUserInfo?.DataPrivileges, null, y => y.ProvinceName);
        }

        public override void DoAdd()
        {           
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}