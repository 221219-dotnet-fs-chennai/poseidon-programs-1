﻿using EF_Layer.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic
{
    public interface ILogic
    {
        List<Patient_M> GetAllPatient();
        Patient_M AddPatient(Patient_M patient);
        Patient_M UpdatePatient(Patient_M patient, int id);
        Patient_M GetByID(int id);

        //visitdetails
        public Visit_Details_M AddVisitDetails(Visit_Details_M visit_Details_M);
        public Visit_Details_M GetVisitDetailsById(int id);

        //prescription
        public Prescription_M AddPrescription(Prescription_M prescription_M);
        public Prescription_M GetPrescriptionById(int id);


    }
}
