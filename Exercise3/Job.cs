using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Job
    {
        private string typeOfWork;
        private double workTime;
        private double hourlyPayment;
        private double total;

        public Job(string typeOfWork, double workTime, double hourlyPayment)
        {
            TypeOfWork = typeOfWork;
            WorkTime = workTime;
            HourlyPayment = hourlyPayment;
           
        }
        public string TypeOfWork 
        { 
            get {  return typeOfWork; }
            set { typeOfWork= value; }
        }
        public double WorkTime
        {
            get { return workTime; }
            set 
            { 
                workTime = value;
                CalcTotalFee();
            }
        }
        public double HourlyPayment
        {
            get { return hourlyPayment; }
            set { 
                hourlyPayment = value; 
                CalcTotalFee(); 
            }
        }
        public double Total 
        { 
            get 
            { 
                return total; 
                
            } 
        }
        public static Job operator +(Job job1, Job job2)
        {
            string newTypeOfJob = job1.TypeOfWork + " and " + job2.TypeOfWork;
            double newTotal = job1.workTime+ job2.workTime;
            double newHourlyPayment = (job1.hourlyPayment+ job2.hourlyPayment) / 2;

            Job addedJob = new Job(newTypeOfJob, newTotal, newHourlyPayment);
            return addedJob;
        }
        private void CalcTotalFee()
        {
             total = hourlyPayment * workTime;
        }

    }


    
}
