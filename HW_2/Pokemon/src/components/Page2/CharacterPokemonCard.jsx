import React from 'react';
import ButtonAbilities from '../buttons/ButtonAbilities';

const CharacterPokemonCard = ({data, type}) => {

    const getStatisticInfo = (type) => {
        const hpStat = data?.stats?.find(object => object?.stat?.name === type);
        
        if (hpStat) {
            return hpStat?.base_stat;
        }
        
        return ""; 
    }

    return (
        <div className='characters_pokemon'>
            <div className='header_pokemon_character'>
                <div className='container_id_name'>
                    <p style={{color: 'gray', fontSize: 18}}>#00{data?.id}</p>
                    <br></br>
                    <h1 className='name_pokemon' style={{color: 'darkblue',}}>{data?.name}</h1>
                </div>
                <div className='button_abilities_container'>
                    {type.map( type =>
                        <ButtonAbilities type={type} className="abilities_button">{type}</ButtonAbilities>
                    )}
                </div>
            </div>
            <div className='body_character_container'>
                <div className='statistic_container'>
                    <div className='hp_container'>
                        <p>HP</p>
                        <div className='hp_level'>
                            <div style={{width: getStatisticInfo('hp') +'%'}} className='attached_level_block'></div>
                        </div>
                    </div>  
                    <div className='attack_container'>
                        <p>Attack</p>
                        <div className='attack_level'>
                            <div style={{width: getStatisticInfo('attack') +'%'}} className='attached_attack_block'></div>
                        </div>
                    </div>  
                    <div className='defense_container'>
                        <p>Defense</p>
                        <div className='defense_level'>
                            <div style={{width: getStatisticInfo('defense') +'%'}} className='attached_defense_block'></div>
                        </div>
                    </div>  
                    <div className='speed_container'>
                        <p>Speed</p>
                        <div className='speed_level'>
                            <div style={{width: getStatisticInfo('speed') +'%'}} className='attached_speed_block'></div>
                        </div>
                    </div>    
                </div>
                <div className='image_pokemon'>
                    <img src={`https://raw.githubusercontent.com/pokeapi/sprites/master/sprites/pokemon/other/dream-world/${data?.id}.svg`} alt={data?.name}></img>
                </div>
            </div>
        </div>    
    );
};

export default CharacterPokemonCard;