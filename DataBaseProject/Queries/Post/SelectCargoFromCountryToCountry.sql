SELECT PostCargo.PublicationDate as PubDate,
LocalityPlace.Name as CityFrom, Country.Name as CountryFrom,
Locality.AddressDetail as AddressFrom
FROM Country 
INNER JOIN LocalityPlace ON Country.Id=LocalityPlace.CountryId
INNER JOIN Locality ON Locality.LocalyPlaceId=LocalityPlace.Id
LEFT JOIN PostCargo ON PostCargo.LocalityFromId = Locality.Id 

