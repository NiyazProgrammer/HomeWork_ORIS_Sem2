import React from 'react';
import '../../App.css'
import { Link } from 'react-router-dom';
import ButtonAbilities from '../buttons/ButtonAbilities';
const PokemonCard = (props) => {
    const name = props.card.name
    return (
        <Link style={{textDecorationLine: 'none'}} to={`/pokemon/${name}`}>
            <div className='pokemon_card'>
                <div className='header_card'>
                    <p className="pokemon_name" >{props.card.name.charAt(0).toUpperCase() + props.card.name.slice(1)}</p>
                    <p style={{color: 'black'}}>#{(props.index + 1).toString().padStart(3, '0')}</p>
                </div>
                <div className='pokemon_image_coniner'>
                    <img className={props.card.image} src={`https://raw.githubusercontent.com/pokeapi/sprites/master/sprites/pokemon/other/dream-world/${props.index + 1}.svg`} alt={props.card.name}></img>
                </div>
                <div className='button_container'>
                    {props.types[props.index] && props.types[props.index].map((type, i) => (
                        <ButtonAbilities type={type} className="abilities_button" key={i}>{type}</ButtonAbilities>
                    ))}
                </div>
            </div>
        </Link>
    );
};

export default PokemonCard;