namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceUpdateOptions : BaseOptions
    {
        [Obsolete("Use ApplicationFeeAmount")]
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// A fee in cents that will be applied to the invoice and transferred to the application
        /// owner’s Stripe account. The request must be made with an OAuth key or the Stripe-Account
        /// header in order to take an application fee. For more information, see the application
        /// fees <see href="https://stripe.com/docs/connect/subscriptions#working-with-invoices">documentation</see>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }

        [JsonProperty("closed")]
        public bool? Closed { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("forgiven")]
        public bool? Forgiven { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Boolean representing whether an invoice is paid or not. To mark invoice as paid, pass true. Only applies to invoices where billing=send_invoice.
        /// </summary>
        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferDataOptions TransferData { get; set; }
    }
}
