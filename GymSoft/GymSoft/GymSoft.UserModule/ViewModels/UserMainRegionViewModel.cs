﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymSoft.UserModule.Model;

namespace GymSoft.UserModule.ViewModels
{
    public class UserMainRegionViewModel : PropertyChangedImplementation
    {
        public UserMainRegionViewModel()
        {

        }
        private User currentUser;
        public User CurrentUser 
        {
            get { return this.currentUser; }
            set
            {
                this.currentUser = value;
                FirePropertyChanged("CurrentUser");
            }
        }
    }
}
