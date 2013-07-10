using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DANikitinTZ.App_LocalResources;
using System.ComponentModel;
using System.Web.Mvc;
using DANikitinTZ.Helpers;

namespace DANikitinTZ.Models
{
    public class Bid
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public virtual int id { get; set; }
        
        /// <summary>
        /// Имя клиента
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName="BidEnterClientName")]
        [LocalizedDisplayName("BidClientName", NameResourceType= typeof(GlobalRes))]
        public virtual string ClientName { get; set; }

        /// <summary>
        /// Дата заявки
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "BidSelectDateBid")]
        [LocalizedDisplayName("BidDateBid", NameResourceType = typeof(GlobalRes))]
        [DataType(DataType.DateTime)]
        public virtual DateTime OrderDate { get; set; }

        /// <summary>
        /// Количество человек
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "BidEnterNumberPersons")]
        [LocalizedDisplayName("BidNumberPersons", NameResourceType = typeof(GlobalRes))]
        //[StringLength(3)]
        [Range(1,1000)]
        public virtual int NumberPersons { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "BidEnterComment")]
        [LocalizedDisplayName("BidComment", NameResourceType = typeof(GlobalRes))]
        public virtual string Comment { get; set; }
    }
}