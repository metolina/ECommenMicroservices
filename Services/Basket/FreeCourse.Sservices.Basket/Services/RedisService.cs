﻿using StackExchange.Redis;

namespace FreeCourse.Sservices.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;
        private readonly int    _port;
        private ConnectionMultiplexer _connectionMultiplexer;
        public RedisService (string host, int port)
        {
            _host=host;
            _port=port;
        }

        public void Connection() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDb(int db=1)=>_connectionMultiplexer.GetDatabase(db);
    }
}
