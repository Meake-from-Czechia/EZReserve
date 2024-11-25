CREATE TABLE `Customers` (
  `CustomerId` int(11) NOT NULL,
  `FirstName` varchar(50)  NOT NULL,
  `LastName` varchar(50)  NOT NULL,
  `Email` varchar(255)  NOT NULL,
  `StreetAddress` varchar(255)  NOT NULL,
  `City` varchar(255)  NOT NULL,
  `PostalCode` varchar(20)  NOT NULL
) ;

CREATE TABLE `Reservations` (
  `ReservationId` int(11) NOT NULL,
  `CustomerId` int(11) NOT NULL,
  `Room` varchar(50)  NOT NULL,
  `Reservation_From` datetime NOT NULL,
  `Reservation_To` datetime NOT NULL
);

ALTER TABLE `Customers`
  ADD PRIMARY KEY (`CustomerId`);

ALTER TABLE `Reservations`
  ADD PRIMARY KEY (`ReservationId`),
  ADD KEY `FK_Reservations_CustomerId` (`CustomerId`);


ALTER TABLE `Customers`
  MODIFY `CustomerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

ALTER TABLE `Reservations`
  MODIFY `ReservationId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;


ALTER TABLE `Reservations`
  ADD CONSTRAINT `FK_Reservations_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customers` (`CustomerId`) ON DELETE CASCADE ON UPDATE NO ACTION;
