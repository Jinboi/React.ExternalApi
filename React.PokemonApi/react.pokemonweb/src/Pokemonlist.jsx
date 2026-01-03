import { useEffect, useState } from "react";

function PokemonList() {
  const [pokemon, setPokemon] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch("https://localhost:7027/api/pokemon") // your API endpoint
      .then(res => res.json())
      .then(data => {
        setPokemon(data);
        setLoading(false);
      })
      .catch(err => {
        console.error("Failed to fetch Pokémon:", err);
        setLoading(false);
      });
  }, []);

  if (loading) return <p>Loading Pokémon...</p>;

  return (
    <div style={{ display: "flex", flexWrap: "wrap", gap: "1rem" }}>
      {pokemon.map(p => (
        <div key={p.index} style={{ border: "1px solid #ccc", padding: "1rem", width: "200px" }}>
          <h3>{p.name}</h3>
          <img src={p.spriteUrl} alt={p.name} />
          <p><strong>Type:</strong> {p.type}</p>
          <p>{p.description}</p>
        </div>
      ))}
    </div>
  );
}

export default PokemonList;
