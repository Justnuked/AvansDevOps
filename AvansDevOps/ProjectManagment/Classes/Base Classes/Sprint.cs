using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using PipeLine.Classes;
using ProjectManagment.Classes;
using Utilities.Observable;


namespace ProjectManagment
{
    //observable pattern
    public class Sprint : Observer
    {
        protected DateTime start;
        protected DateTime end;
        private double interval = 1000 * 60 * 60 * 24;
        private System.Timers.Timer t;

        public bool active;
        private bool addReviewDocument = false;
        private bool finished = false;

        private Backlog backlog;
        private ReviewDocument document;

        private Pipeline pipeline;

        public Sprint()
        {
            active = false;
            t = new System.Timers.Timer(interval);
            t.Elapsed += new ElapsedEventHandler(CheckForTime_Elapsed);
            t.Enabled = true;

            backlog = new Backlog(this);
        }

        public Sprint(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }

        public void AddPipeline(Pipeline pipeline)
        {
            this.pipeline = pipeline;
        }
            
        public ReviewDocument GetDocument()
        {
            return document;
        }

        public void FinishSprint()
        {
            if (active == false)
            {
                pipeline.Subscribe(this);
                pipeline.Execute();
                
            }
        }

        public void AddReviewDocument(ReviewDocument document)
        {
            if (addReviewDocument && pipeline.GetPipeLineType() == Pipeline.PipeLineType.DEVELOPMENT)
            {
                this.document = document;
            }
        }

        public void Start()
        {
            active = true;
        }

        private void CheckForTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Today == this.end)
            {
                active = false;
                addReviewDocument = true;
            }
        }

        public void Update(string message, bool? status)
        {
            if ((bool) status)
            {
                finished = true;
            }
            else
            {
                finished = false;
                //notify scrummaster build failed
            }
        }
    }
}
