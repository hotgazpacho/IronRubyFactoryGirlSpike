require 'rubygems'
require 'factory_girl'
require 'FactoryGirlSpike.dll'

include FactoryGirlSpike::Poco

# Let's define a sequence that factories can use.  This sequence defines a
# unique e-mail address.  The first address will be "somebody1@example.com",
# and the second will be "somebody2@example.com."
Factory.sequence :email do |n|
  "somebody#{n}@example.com"
end

# Let's define a factory for the User model. The class name is guessed from the
# factory name.
Factory.define :user do |f|
  # These properties are set statically, and are evaluated when the factory is
  # defined.
  f.first_name 'John'
  f.last_name  'Doe'
  f.admin      false
  # This property is set "lazily." The block will be called whenever an
  # instance is generated, and the return value of the block is used as the
  # value for the attribute.
  f.email      { Factory.next(:email) }
end

