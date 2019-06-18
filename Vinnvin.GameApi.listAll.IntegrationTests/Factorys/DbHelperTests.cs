using MongoDB.Driver;
using Moq;
using System;
using System.Collections.Generic;
using Vinnvin.GameApi.listAll.Contracts;
using Vinnvin.GameApi.listAll.Factorys;
using Vinnvin.GameApi.listAll.Models;
using Xunit;

namespace Vinnvin.GameApi.listAll.IntegrationTests.Factorys
{
    public class DbHelperTests : IDisposable
    {
        private readonly IDbHelper dbHelper;
        private readonly IDbSettings dbSettings;
        private readonly MongoClient _client;
        private readonly IMongoCollection<Game> _games;
        public DbHelperTests()
        {
            
            var mockSettings = new Mock<IDbSettings>();
            mockSettings.Setup(x => x.Collection).Returns(Guid.NewGuid().ToString());
            mockSettings.Setup(x => x.DbName).Returns(Guid.NewGuid().ToString());
            mockSettings.Setup(x => x.ConnectionString).Returns("mongodb://localhost:27017");
            dbSettings = mockSettings.Object;

            dbHelper = new DbHelper(dbSettings);

            _client = new MongoClient(dbSettings.ConnectionString);
            var dbgames = _client.GetDatabase(dbSettings.DbName);
            _games = dbgames.GetCollection<Game>(dbSettings.Collection);
            setupdata();
        }

        public void Dispose()
        {
            _client.DropDatabase(dbSettings.DbName);
        }

        private void setupdata()
        {
            var list = new List<Game>()
            {
                new Game()
                {
                    DeadLine = DateTime.Now,
                    Deleted = false,
                    Description = "text",
                    GameId = "a1",
                    Name = "name",
                    Vochers = new List<Vocher>()
                    {
                        new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b1",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b2",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b3",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b4",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        }
                    }
                },
                new Game()
                {
                    DeadLine = DateTime.Now,
                    Deleted = false,
                    Description = "text",
                    GameId = "a2",
                    Name = "name",
                    Vochers = new List<Vocher>()
                    {
                        new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b1",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b2",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b3",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b4",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        }
                    }
                },
                new Game()
                {
                    DeadLine = DateTime.Now,
                    Deleted = false,
                    Description = "text",
                    GameId = "a3",
                    Name = "name",
                    Vochers = new List<Vocher>()
                    {
                        new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b1",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b2",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b3",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        },new Vocher()
                        {
                            PerchesTime = DateTime.Now,
                            TicketId = "b4",
                            Tickets = new List<Ticket>()
                            {
                                new Ticket(){Price = 2,TicketId = "c1"},
                                new Ticket(){Price = 2,TicketId = "c2"},
                                new Ticket(){Price = 2,TicketId = "c3"},
                                new Ticket(){Price = 2,TicketId = "c4"}
                            }
                        }
                    }
                }
            };
            _games.InsertMany(list);
        }

        [Fact]
        public void GetData_notEmpty()
        {
            var answer = dbHelper.GetData();
            Assert.NotEmpty(answer);
        }
    }
}
