﻿using Dibware.EF.Extensions.Base;
using Dibware.EF.Extensions.Contracts;
using System;
using System.Collections.Generic;

namespace Dibware.Template.Infrastructure.SqlDataAccess.StoredProcedures.Membership
{
    /// <summary>
    /// Represents the security.Membership_GetHashedPassword stored procedure
    /// </summary>
    public class GetPasswordStoredProcedure : BaseStoredProcedure<String>, IStoredProcedure<String>
    {
        public const String ProcedureName = @"Membership_GetPassword";
        public const String ProcedureSchema = @"security";

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPasswordStoredProcedure"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        public GetPasswordStoredProcedure(String username)
            : base(ProcedureSchema, ProcedureName, new Dictionary<String, Object>()
                {
                    { "username", username }
                })
        { }
    }
}