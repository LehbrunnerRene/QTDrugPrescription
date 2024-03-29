﻿//@CodeCopy
//MdStart

namespace QTDrugPrescription.Logic.Entities
{
    public abstract partial class IdentityEntity : IIdentifyable
    {
        /// <summary>
        /// ID of the entity (primary key)
        /// </summary>
        [Key]
        public int Id { get; internal set; }
    }
}
//MdEnd
