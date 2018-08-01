﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineJudge.Models {
    public class Contest {
        public int Id{ set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        
        public virtual User Creator { set; get; }
        
        public ICollection<ContestProblem> Problems { set; get; }
        public ICollection<Contestant> Contestants { set; get; }
        public ICollection<ContestantSubmission> Submissions { set; get; }
    }

    public class ContestProblem {
        public int Id{ set; get; }
        // todo make auto increment
        public int Order { set; get; }
        
        public virtual Contest Contest { set; get; }
        public virtual Problem Problem { set; get; }
        
        public ICollection<ContestantSubmission> Submissions { set; get; }
    }


    public class Contestant{
        public int Id{ set; get; }
        public int Score { set; get; }
        public virtual User User { set; get; }
        public virtual Contest Contest { set; get; }

        public ICollection<ContestantSubmission> Submissions { set; get; }
    }

    public class ContestantSubmission{
        public int Id{ set; get; }
        public int Score { set; get; }

        public virtual Submission Submission { set; get; }
        public virtual Contestant Submitter { set; get; }
        public virtual ContestProblem Problem { set; get; }
    }
}