SELECT superheroes.pseudonym 
FROM 
superheroes 
JOIN heroes_skill ON superheroes.id_heroes = heroes_skill.id_heroes AND heroes_skill.subjective_assessment>=5 
GROUP BY 
superheroes.id_heroes, superheroes.pseudonym 
ORDER BY COUNT(*) DESC