CREATE TABLE [Players] (
	id integer,
	name varchar(50) NOT NULL UNIQUE,
	password_hash binary,
  CONSTRAINT [PK_PLAYERS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Games] (
	id integer,
	created_at datetime NOT NULL,
	updated_at datetime NOT NULL,
	turn_player_id integer NOT NULL,
	die0 integer NOT NULL,
	die1 integer NOT NULL,
	die2 integer NOT NULL,
	die3 integer NOT NULL,
	die4 integer NOT NULL,
	throw integer NOT NULL,
  CONSTRAINT [PK_GAMES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [PlayerGames] (
	id integer NOT NULL,
	player_id integer NOT NULL,
	game_id integer NOT NULL,
  CONSTRAINT [PK_PLAYERGAMES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ScoreTables] (
	id integer NOT NULL,
	player_game_id integer NOT NULL,
	throw_column integer NOT NULL,
	ones integer,
	twos integer,
	threes integer,
	fours integer,
	fives integer,
	sixes integer,
	pair integer,
	twoPairs integer,
	threeSame integer,
	fourSame integer,
	smallStraight integer,
	bigStraight integer,
	fullHouse integer,
	sum integer,
	yatzy integer,
  CONSTRAINT [PK_SCORETABLES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO


ALTER TABLE [PlayerGames] WITH CHECK ADD CONSTRAINT [PlayerGames_fk0] FOREIGN KEY ([player_id]) REFERENCES [Players]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [PlayerGames] CHECK CONSTRAINT [PlayerGames_fk0]
GO
ALTER TABLE [PlayerGames] WITH CHECK ADD CONSTRAINT [PlayerGames_fk1] FOREIGN KEY ([game_id]) REFERENCES [Games]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [PlayerGames] CHECK CONSTRAINT [PlayerGames_fk1]
GO

ALTER TABLE [ScoreTables] WITH CHECK ADD CONSTRAINT [ScoreTables_fk0] FOREIGN KEY ([player_game_id]) REFERENCES [PlayerGames]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [ScoreTables] CHECK CONSTRAINT [ScoreTables_fk0]
GO

