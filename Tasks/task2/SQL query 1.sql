SELECT superheroes.pseudonym 
FROM 
superheroes 
JOIN heroes_skill ON superheroes.id_heroes = heroes_skill.id_heroes 
GROUP BY 
superheroes.id_heroes, superheroes.pseudonym 
HAVING COUNT(*) >=2