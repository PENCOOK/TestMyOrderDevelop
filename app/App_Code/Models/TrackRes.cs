using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TrackRes
/// </summary>
public class TrackRes
{
    public partial class Welcome
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("trackingNo")]
        public string TrackingNo { get; set; }

        [JsonProperty("courier")]
        public string Courier { get; set; }

        [JsonProperty("courierKey")]
        public string CourierKey { get; set; }

        [JsonProperty("shareLink")]
        public Uri ShareLink { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currentStatus")]
        public string CurrentStatus { get; set; }

        [JsonProperty("detail")]
        public DataDetail Detail { get; set; }

        [JsonProperty("timelines")]
        public Timeline[] Timelines { get; set; }
    }

    public partial class DataDetail
    {
        [JsonProperty("trackingNo")]
        public string TrackingNo { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("qty")]
        public long Qty { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("originCity")]
        public string OriginCity { get; set; }

        [JsonProperty("originProvince")]
        public string OriginProvince { get; set; }

        [JsonProperty("originCountry")]
        public string OriginCountry { get; set; }

        [JsonProperty("originPostcode")]
        public string OriginPostcode { get; set; }

        [JsonProperty("destinationCity")]
        public string DestinationCity { get; set; }

        [JsonProperty("destinationProvince")]
        public string DestinationProvince { get; set; }

        [JsonProperty("destinationCountry")]
        public string DestinationCountry { get; set; }


        public long DestinationPostcode { get; set; }

        [JsonProperty("signer")]
        public string Signer { get; set; }

        [JsonProperty("signerImageURL")]
        public string SignerImageUrl { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("shippingService")]
        public string ShippingService { get; set; }

        [JsonProperty("returnShippingService")]
        public string ReturnShippingService { get; set; }

        [JsonProperty("deliveryType")]
        public string DeliveryType { get; set; }

        [JsonProperty("packaging")]
        public string Packaging { get; set; }

        [JsonProperty("senderPhoneNumber")]
        public string SenderPhoneNumber { get; set; }

        [JsonProperty("recipientPhoneNumber")]
        public string RecipientPhoneNumber { get; set; }

        [JsonProperty("pickupDate")]
        public DateTimeOffset PickupDate { get; set; }

        [JsonProperty("sendDate")]
        public string SendDate { get; set; }

        [JsonProperty("dueDate")]
        public DateTimeOffset DueDate { get; set; }

        public long CashOnDelivery { get; set; }

        [JsonProperty("isPayCashOnDelivery")]
        public bool IsPayCashOnDelivery { get; set; }

        [JsonProperty("deliveryStaffName")]
        public string DeliveryStaffName { get; set; }

        [JsonProperty("deliveryStaffPhoneNumber")]
        public string DeliveryStaffPhoneNumber { get; set; }

        [JsonProperty("deliveryStaffBranchPhoneNumber")]
        public string DeliveryStaffBranchPhoneNumber { get; set; }

        [JsonProperty("senderCompany")]
        public string SenderCompany { get; set; }

        [JsonProperty("senderAddress")]
        public string SenderAddress { get; set; }

        [JsonProperty("recipientCompany")]
        public string RecipientCompany { get; set; }

        [JsonProperty("recipientAddress")]
        public string RecipientAddress { get; set; }

        [JsonProperty("courierPartnerTrackingNo")]
        public string CourierPartnerTrackingNo { get; set; }

        [JsonProperty("courierPartner")]
        public string CourierPartner { get; set; }

        [JsonProperty("courierPartnerKey")]
        public string CourierPartnerKey { get; set; }

        [JsonProperty("businessPartner")]
        public string BusinessPartner { get; set; }

        [JsonProperty("deliveryTime")]
        public long DeliveryTime { get; set; }

        [JsonProperty("returnTrackingNo")]
        public string ReturnTrackingNo { get; set; }

        [JsonProperty("returnCourier")]
        public string ReturnCourier { get; set; }

        [JsonProperty("returnCourierKey")]
        public string ReturnCourierKey { get; set; }
        public long Freight { get; set; }

        [JsonProperty("payType")]
        public string PayType { get; set; }

        [JsonProperty("priceMethod")]
        public string PriceMethod { get; set; }

        [JsonProperty("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("deliveryTimeSlot")]
        public string DeliveryTimeSlot { get; set; }
    }

    public partial class Timeline
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("details")]
        public DetailElement[] Details { get; set; }
    }
    public partial class DetailElement
    {
        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}