SELECT firstName, lastName,city, state
FROM person
LEFT JOIN address
ON person.personId=address.personId
ORDER BY person.personId