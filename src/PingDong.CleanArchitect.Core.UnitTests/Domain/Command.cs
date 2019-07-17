﻿using System;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class CommandTest
    {
        [Fact]
        public void Command_EmptyCtor()
        {
            var evt = new Command();

            Assert.Equal(default, evt.CorrelationId);
            Assert.Equal(default, evt.TenantId);
        }

        [Fact]
        public void Command_Ctor()
        {
            var correlationId = Guid.NewGuid();
            var tenantId = Guid.NewGuid();

            var evt = new Command(tenantId, correlationId);

            Assert.Equal(correlationId, evt.CorrelationId);
            Assert.Equal(tenantId, evt.TenantId);
        }

        [Fact]
        public void Command_Property()
        {
            var correlationId = Guid.NewGuid();
            var tenantId = Guid.NewGuid();

            var evt = new Command
            {
                CorrelationId = correlationId,
                TenantId = tenantId
            };

            Assert.Equal(correlationId, evt.CorrelationId);
            Assert.Equal(tenantId, evt.TenantId);
        }
    }
}
