import React, { useEffect, useState } from 'react';
import '../styles/Pokemon_page.css'
import ButtonAbilities from '../buttons/ButtonAbilities';
import HeaderContentPage2 from './HeaderContentPage2';
import CharacterPokemonCard from './CharacterPokemonCard';
import BreeedingCard from './BreeedingCard';
import MovesCard from './MovesCard';


const CharacterPokemonPage = (props) => {
    const [data, setData] = useState([])
    const [pokemonType, setpokemonType] = useState([])
    async function getInfo(){
        const response = await fetch(`https://pokeapi.co/api/v2/pokemon/${props.name}`)
        const data = await response.json()
        setData(data)
        // console.log(data.moves[0].move.name)
        console.log(data)
        const types = data.types.map(type => type.type.name);
        setpokemonType(types)
    }
    useEffect(() =>{
        getInfo()
    }, [])
    
    return (
        <div>
            <HeaderContentPage2/>
            <main> 
                <div className='content_block'>
                    <CharacterPokemonCard data={data} type={pokemonType}/>
                    <BreeedingCard data={data}/>
                    <MovesCard data={data}/>
                </div>
            </main>
        </div>
    );
};

export default CharacterPokemonPage;