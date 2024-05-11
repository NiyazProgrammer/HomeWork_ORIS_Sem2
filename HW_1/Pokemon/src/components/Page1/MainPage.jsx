import React, { useEffect, useState } from 'react';
import '../../App.css';
import FormHeaderTitleAndSearchPokemon from './FormHeaderTitleAndSearchPokemon';
import PokemonListCards from './PokemonListCards';
import PokemonNotFound from '../../Images/NotFoundPokemon.png'; 
const MainPage = () => {
    const [cards, setCards] = useState([])

    const [searchPokemons,setSearchPokemons] = useState([])

  const searchPokemonAction = (text) => {
   var newSearchPokemons =  cards.filter(card => card.name.toLowerCase().includes(text.toLowerCase()))
   setSearchPokemons(newSearchPokemons)
  }
  
  useEffect(() => {
    async function getPoks() {
      try {
        const res = await fetch("https://pokeapi.co/api/v2/pokemon?limit=151");
        const data = await res.json();
        setCards(data.results);
        setSearchPokemons(data.results)
      } catch (error) {
        console.error("Error fetching Pokemon data:", error);
      }
    }
    getPoks();
  }, []);

  const [pokTypes, setPokTypes] = useState([]);

  useEffect(() => {
    async function fetchPokemonTypes() {
      const types = await Promise.all(
        cards.map(async (card) => {
          const response = await fetch(card.url);
          const data = await response.json();
          return data.types.map(type => type.type.name);
        })
      );
      setPokTypes(types);
    }
    fetchPokemonTypes();
  }, [cards]);

    return (
        <div className='wrapper_main_page'>
            <header>
                <FormHeaderTitleAndSearchPokemon action={searchPokemonAction}/>
            </header>
            <main>
                
                {searchPokemons.length !== 0
                  ? 
                  <PokemonListCards cards={searchPokemons} types={pokTypes}/>
                  : 
                  <div className='not_found_container'>
                    <h1>Oops! Try again.</h1>
                    <br/>
                    <div className='description_not_found'>
                      The Pokemon you're looking for is a unicorn. It doesn't exist in this list.
                    </div>
                    <img src={PokemonNotFound} className='pokemon_not_found'/> 
                  </div>
                }
            </main> 
        </div>
    );
};

export default MainPage;