import React from 'react';
import CharacterPokemonPage from './CharacterPokemonPage';
import { useParams } from 'react-router-dom';

const PokemonInfoPage = () => {
    let {name} = useParams()
    return (
        <div>
            <CharacterPokemonPage name = {name}/>
        </div>
    );
};

export default PokemonInfoPage;