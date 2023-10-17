﻿using CommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IPatientSL
    {
        Task<GetAllDoctorListResponse> GetAllDoctorList();

        Task<AddAppointmentResponse> AddAppointment(AddAppointmentRequest request);
        Task<UpdateAppointmentResponse> UpdateAppointment(UpdateAppointmentRequest request);
        Task<GetAppointmentResponse> GetAppointment(string UserID);
        Task<DeleteAppointmentResponse> DeleteAppointment(string Id);
        Task<AddFeedbackResponse> AddFeedback(AddFeedbackRequest request);
        Task<SubmitPaymentResponse> SubmitPayment(string UserID);
    }
}
