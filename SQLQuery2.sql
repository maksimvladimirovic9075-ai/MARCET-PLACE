IF OBJECT_ID('dbo.Favorites', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Favorites
    (
        FavoriteID INT IDENTITY(1,1) PRIMARY KEY,
        UserID INT NOT NULL REFERENCES dbo.Users(UserID),
        ProductID INT NOT NULL REFERENCES dbo.Products(ProductID),
        UNIQUE(UserID, ProductID)
    );
END;

IF OBJECT_ID('dbo.Cart', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Cart
    (
        CartID INT IDENTITY(1,1) PRIMARY KEY,
        UserID INT NOT NULL REFERENCES dbo.Users(UserID),
        ProductID INT NOT NULL REFERENCES dbo.Products(ProductID),
        Quantity INT NOT NULL DEFAULT 1,
        UNIQUE(UserID, ProductID)
    );
END;