import { useEffect, useState } from "react";

function PokemonList() {
    const [pokemon, setPokemon] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch("https://localhost:7027/api/pokemon")
            .then(res => {
                if (!res.ok) {
                    throw new Error("Server responded with an error");
                }
                return res.json();
            })
            .then(data => {
                setPokemon(data);
                setError(null);
            })
            .catch(err => {
                console.error("Failed to fetch Pokémon:", err);
                setError("Unable to load Pokémon. Please try again later.");
            })
            .finally(() => {
                setLoading(false);
            });
    }, []);

    if (loading) return <p>Loading Pokémon...</p>;

    if (error) {
        return (
            <p style={{ color: "red", fontWeight: "bold" }}>
                {error}
            </p>
        );
    }

    return (
        <div style={{ display: "flex", flexWrap: "wrap", gap: "1rem" }}>
            {pokemon.map(p => (
                <div
                    key={p.index}
                    style={{ border: "1px solid #ccc", padding: "1rem", width: "200px" }}
                >
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
