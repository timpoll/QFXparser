﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QFXparser
{
    [NodeName("CCSTMTRS")]
    internal class RawStatement
    {
        [NodeName("ACCTID")]
        public string AccountNum { get; set; }

        [NodeName("BANKTRANLIST")]
        public ICollection<RawTransaction> Transactions { get; set; } = new List<RawTransaction>();

        [NodeName("LEDGERBAL")]
        public RawLedgerBalance LedgerBalance { get; set; } = new RawLedgerBalance();

        //[NodeName("AVAILBAL")] 
        //public RawAvailableBalance AvailableBalance { get; set; } = new RawAvailableBalance();
    }
}
